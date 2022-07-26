using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopG5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace OnlineShopG5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Trangchu( int paging, string Search = "")
        {
            using (var ct = new ShopPRNContext())
            {
                

                int page = 0;
                
                
                if (Search == "") { 
                    List<Product>listP = ct.Products.OrderBy(x => x.ProductId).ToList();
                    ViewBag.listP = listP.Skip(paging * 15).Take(15).ToList();
                    if (listP.Count % 15 == 0)
                    {
                        page = listP.Count / 15;
                    }
                    else
                    {
                        page = listP.Count / 15 + 1;
                    }
                } else
                {
                    List<Product> listP = ct.Products.Where(x => x.ProductName.Contains(Search)).OrderBy(x => x.ProductId).ToList();
                    ViewBag.listP = listP.Skip(paging * 15).Take(15).ToList();
                    if (listP.Count % 15 == 0)
                    {
                        page = listP.Count / 15;
                    }
                    else
                    {
                        page = listP.Count / 15 + 1;
                    }
                }
                ViewBag.page = page;
                
                ViewBag.paging = paging;
                List<Category> listC = ct.Categories.ToList();
                
                

                ViewBag.listC = listC;
               
                //luu session

                //lay thong tin tu session  
                string id = HttpContext.Session.GetString("id");
                
                string role = HttpContext.Session.GetString("role");

                string sum = HttpContext.Session.GetString("quantitySp");

                string cart1 = HttpContext.Session.GetString("cart");
                if (sum == null)
                {
                    sum = "0";
                }
                ViewBag.quantitySp = sum;
                ViewBag.id = id;
                ViewBag.role = role;


                string json = HttpContext.Session.GetString("cart");
                if (json != null)
                {
                    IDictionary<int, int> cart = JsonSerializer.Deserialize<Dictionary<int, int>>(json);
                    double? sum1 = 0;
                    foreach (KeyValuePair<int, int> item in cart)
                    {
                        using (var context = new ShopPRNContext())
                        {
                            Product sp = context.Products.Where(x => x.ProductId == item.Key).SingleOrDefault();
                            sum1 += sp.Price * item.Value;
                        }
                    }
                    ViewBag.sum = sum1;
                    ViewBag.cart = cart;
                }
                else
                {

                }
                
            }
            return View();
        }

        

        public IActionResult FormLogin()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login()
        {
            string user = HttpContext.Request.Form["username"];
            string pass = HttpContext.Request.Form["password"];
            using (var ct = new ShopPRNContext())
            {
                User a = ct.Users.Where(x => x.Username == user && x.Password == pass).SingleOrDefault();
                if (a != null)
                {
                    //tao sesssion
                    HttpContext.Session.SetString("id", a.UserId.ToString());
                    HttpContext.Session.SetString("role", a.RoleId.ToString());
                    return Redirect("/Home/Trangchu");
                }
                else
                {
                    return Redirect("/Home/FormLogin");
                }
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/Home/Trangchu");
        }

        public IActionResult AddSp(int id)
        {
            string cart1 = HttpContext.Session.GetString("cart");

            IDictionary<int, int> cart = new Dictionary<int, int>();
            // kiem tra xem session cart da co chua
            if (cart1 != null)
            {
                cart = JsonSerializer.Deserialize<Dictionary<int, int>>(cart1);
                if (cart.ContainsKey(id))
                {
                    cart[id] += 1;
                }
                else
                {
                    cart.Add(id, 1);
                }
            }
            else
            {
                cart.Add(id, 1);
            }

            int total = 0;
            foreach (KeyValuePair<int, int> item in cart)
            {
                total += item.Value;
            }
            HttpContext.Session.SetString("quantitySp", total.ToString());

            //Chuyen cart ve string de luu trong session
            string jsonData = JsonSerializer.Serialize(cart);
            HttpContext.Session.SetString("cart", jsonData);
            return Redirect("/Home/Trangchu");
        }

        public IActionResult ViewCart()
        {
            string json = HttpContext.Session.GetString("cart");
            IDictionary<int, int> cart = JsonSerializer.Deserialize<Dictionary<int, int>>(json);
            double? sum = 0;
            foreach (KeyValuePair<int, int> item in cart)
            {
                using (var context = new ShopPRNContext())
                {
                    Product sp = context.Products.Where(x => x.ProductId == item.Key).SingleOrDefault();
                    sum += sp.Price * item.Value;
                }
            }
            ViewBag.sum = sum;
            ViewBag.cart = cart;

            string id = HttpContext.Session.GetString("id");
            string role = HttpContext.Session.GetString("role");
            ViewBag.id = id;
            ViewBag.role = role;
            return View();
        }

        public IActionResult BotHang(int id)
        {
            string cart1 = HttpContext.Session.GetString("cart");

            IDictionary<int, int> cart = new Dictionary<int, int>();
            // kiem tra xem session cart da co chua
            if (cart1 != null)
            {
                cart = JsonSerializer.Deserialize<Dictionary<int, int>>(cart1);
                if (cart.ContainsKey(id))
                {
                    if (cart[id] == 1)
                    {
                        cart.Remove(id);
                    }
                    else
                    {
                        cart[id] -= 1;
                    }
                }

            }


            int total = 0;
            foreach (KeyValuePair<int, int> item in cart)
            {
                total += item.Value;
            }
            HttpContext.Session.SetString("quantitySp", total.ToString());

            //Chuyen cart ve string de luu trong session
            string jsonData = JsonSerializer.Serialize(cart);
            HttpContext.Session.SetString("cart", jsonData);
            return RedirectToAction("ViewCart");
        }

        public IActionResult ThemHang(int id)
        {
            string cart1 = HttpContext.Session.GetString("cart");

            IDictionary<int, int> cart = new Dictionary<int, int>();
            // kiem tra xem session cart da co chua
            if (cart1 != null)
            {
                cart = JsonSerializer.Deserialize<Dictionary<int, int>>(cart1);
                if (cart.ContainsKey(id))
                {
                    cart[id] += 1;
                }

            }


            int total = 0;
            foreach (KeyValuePair<int, int> item in cart)
            {
                total += item.Value;
            }
            HttpContext.Session.SetString("quantitySp", total.ToString());

            //Chuyen cart ve string de luu trong session
            string jsonData = JsonSerializer.Serialize(cart);
            HttpContext.Session.SetString("cart", jsonData);
            return RedirectToAction("ViewCart");
        }


        public IActionResult AddHD(int sum)
        {
            string note = HttpContext.Request.Form["note"];
            string id = HttpContext.Session.GetString("id");
            using var context = new ShopPRNContext();
            List<Order> list = context.Orders.ToList();
            int count = list.Count + 1;


            Order d = new Order();
            
            d.UserId = int.Parse(id);
            d.Total = sum;
            //d.Note = note;
            d.CreatedTime = DateTime.Now;
            d.Status = 1;
            context.Orders.Add(d);
            context.SaveChanges();


            string cart1 = HttpContext.Session.GetString("cart");
            IDictionary<int, int> cart = new Dictionary<int, int>();
            cart = JsonSerializer.Deserialize<Dictionary<int, int>>(cart1);

            int count1 = context.Orders.Count();
            Order c1 = context.Orders.Where(x => x.OrderId == count1).SingleOrDefault();
            foreach (KeyValuePair<int, int> item in cart)
            {
                OrderDetail ct = new OrderDetail();
                Product p = context.Products.Where(x => x.ProductId == item.Key).SingleOrDefault();
                ct.OrderId = c1.OrderId;  
                ct.ProductId = item.Key; // key là product id
                ct.Quantity = item.Value;
                p.Quantity = p.Quantity - ct.Quantity;
                context.Products.Update(p);
                context.OrderDetails.Add(ct);
                context.SaveChanges();
            }

            //sau khi thanh toan xoa het cac sp trong cart
            cart = new Dictionary<int, int>();
            string jsonData = JsonSerializer.Serialize(cart);
            HttpContext.Session.SetString("cart", jsonData);

            //set quantity cua gio hang
            int total1 = 0;
            foreach (KeyValuePair<int, int> item in cart)
            {
                total1 += item.Value;
            }
            HttpContext.Session.SetString("quantitySp", total1.ToString());
            return RedirectToAction("Trangchu");
        }

        public IActionResult Manager()
        {
            using var context = new ShopPRNContext();
            List<Product> list = context.Products.ToList();
            ViewBag.list = list;
            List<Category> listC = context.Categories.ToList();
            ViewBag.listC = listC;
            return View();
        }

        public IActionResult AnHien(int id, int loai)
        {
            using var context = new ShopPRNContext();
            Product sp = context.Products.Where(x => x.ProductId == id).SingleOrDefault();
            if (loai == 0)
            {
                sp.Status = false;
            }
            else
            {
                sp.Status = true;
            }
            context.Products.Update(sp);
            context.SaveChanges();
            return RedirectToAction("Manager");
        }
        //them san phamr
        public IActionResult AddNewSp()
        {
            string ten = HttpContext.Request.Form["nameSp"];
            string description = HttpContext.Request.Form["description"];
            string cate = HttpContext.Request.Form["category"];            
            string url = HttpContext.Request.Form["url"];
            string gia = HttpContext.Request.Form["price"];
            string soluong = HttpContext.Request.Form["quantity"];


            using var context = new ShopPRNContext();
            Product sp = new Product();
            sp.ProductName = ten;
            sp.Description = description;
            sp.CategoryId = int.Parse(cate);
            sp.Image = url;
            sp.Price = int.Parse(gia);
            sp.Quantity = int.Parse(soluong);
            sp.Status = true;
            context.Products.Add(sp);
            context.SaveChanges();
            return RedirectToAction("Manager");
        }
        //update sp 
        public IActionResult UpdateSp(int id)
        {
            using var context = new ShopPRNContext();
            Product sp = context.Products.Where(x => x.ProductId == id).SingleOrDefault();
            ViewBag.sp = sp;
            List<Category> ct = context.Categories.ToList();
            ViewBag.listC = ct;
            return View();
        }

        [HttpPost]
        public IActionResult EditSp(int id)
        {
            //string ten = HttpContext.Request.Form["nameSp"];
            //string url = HttpContext.Request.Form["url"];
            //string gia = HttpContext.Request.Form["price"];
            //string soluong = HttpContext.Request.Form["quantity"];

            using var context = new ShopPRNContext();
            Product sp = context.Products.Where(x => x.ProductId == id).SingleOrDefault();
            sp.ProductName = HttpContext.Request.Form["nameSp"];
            sp.Description = HttpContext.Request.Form["description"];
            sp.CategoryId = int.Parse(HttpContext.Request.Form["category"]);
            sp.Image = HttpContext.Request.Form["url"];
            sp.Price = int.Parse(HttpContext.Request.Form["price"]);
            sp.Quantity = int.Parse(HttpContext.Request.Form["quantity"]);
            context.SaveChanges();
            return RedirectToAction("Manager");
        }

        public IActionResult DanhSachDonHang()
        {
            using (var context = new ShopPRNContext())
            {
                List<Order> list = context.Orders.ToList();
                foreach (Order item in list)
                {
                    item.User = context.Users.Where(x => x.UserId == item.UserId).Single();
                }
                ViewBag.list = list;
            }
            return View();
        }

        public IActionResult RegisterForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register()
        {
            User us = new User();
            using(var context = new ShopPRNContext())
            {
                us.FirstName = HttpContext.Request.Form["fname"];
                us.LastName = HttpContext.Request.Form["lname"];
                us.RoleId = 2;
                us.Username = HttpContext.Request.Form["username"];
                us.Password = HttpContext.Request.Form["password"];
                us.Phone = HttpContext.Request.Form["phone"];
                us.Address = HttpContext.Request.Form["address"];
                us.Email = HttpContext.Request.Form["gmail"];
                us.Status = true;

                context.Users.Add(us);
                context.SaveChanges();
            }
            return Redirect("/Home/FormLogin");
        }

        
        public IActionResult CategoryFilter(int cateid)
        {
            using (var ct = new ShopPRNContext())
            {


                int page = 0;


                ViewBag.category = cateid;
                List<Product> listP = ct.Products.OrderBy(x => x.ProductId).ToList();
                ViewBag.listP = listP.Where(x=>x.CategoryId == cateid).ToList();
 
                List<Category> listC = ct.Categories.ToList();



                ViewBag.listC = listC;

                //luu session

                //lay thong tin tu session  
                string id = HttpContext.Session.GetString("id");
                string role = HttpContext.Session.GetString("role");

                string sum = HttpContext.Session.GetString("quantitySp");

                string cart1 = HttpContext.Session.GetString("cart");
                if (sum == null)
                {
                    sum = "0";
                }
                ViewBag.quantitySp = sum;
                ViewBag.id = id;
                ViewBag.role = role;


                string json = HttpContext.Session.GetString("cart");
                if (json != null)
                {
                    IDictionary<int, int> cart = JsonSerializer.Deserialize<Dictionary<int, int>>(json);
                    double? sum1 = 0;
                    foreach (KeyValuePair<int, int> item in cart)
                    {
                        using (var context = new ShopPRNContext())
                        {
                            Product sp = context.Products.Where(x => x.ProductId == item.Key).SingleOrDefault();
                            sum1 += sp.Price * item.Value;
                        }
                    }
                    ViewBag.sum = sum1;
                    ViewBag.cart = cart;
                }
                else
                {

                }

            }
            return View();
        }
        public IActionResult NewProduct()
        {
            using (var ct = new ShopPRNContext())
            {


                int page = 0;


               
                List<Product> listP = ct.Products.OrderBy(x => x.ProductId).ToList();
                ViewBag.listP = listP.OrderByDescending(x=>x.ProductId).ToList();

                List<Category> listC = ct.Categories.ToList();



                ViewBag.listC = listC;

                //luu session

                //lay thong tin tu session  
                string id = HttpContext.Session.GetString("id");
                string role = HttpContext.Session.GetString("role");

                string sum = HttpContext.Session.GetString("quantitySp");

                string cart1 = HttpContext.Session.GetString("cart");
                if (sum == null)
                {
                    sum = "0";
                }
                ViewBag.quantitySp = sum;
                ViewBag.id = id;
                ViewBag.role = role;


                string json = HttpContext.Session.GetString("cart");
                if (json != null)
                {
                    IDictionary<int, int> cart = JsonSerializer.Deserialize<Dictionary<int, int>>(json);
                    double? sum1 = 0;
                    foreach (KeyValuePair<int, int> item in cart)
                    {
                        using (var context = new ShopPRNContext())
                        {
                            Product sp = context.Products.Where(x => x.ProductId == item.Key).SingleOrDefault();
                            sum1 += sp.Price * item.Value;
                        }
                    }
                    ViewBag.sum = sum1;
                    ViewBag.cart = cart;
                }
                else
                {

                }

            }
            return View();           
        }

        public IActionResult UserProfile()
        {
            string id = HttpContext.Session.GetString("id");

            string role = HttpContext.Session.GetString("role");

            string sum = HttpContext.Session.GetString("quantitySp");

            string cart1 = HttpContext.Session.GetString("cart");
            
            if (sum == null)
            {
                sum = "0";
            }
            ViewBag.quantitySp = sum;
            ViewBag.id = id;
            ViewBag.role = role;

            using( var ct = new ShopPRNContext())
            {
                User u = ct.Users.Where(x => x.UserId == int.Parse(id)).FirstOrDefault();
                ViewBag.user = u;
            }
            return View();
        }
        [HttpPost]
        public IActionResult updateUser(int userid)
        {

            using var ct = new ShopPRNContext(); 
            
                User us = ct.Users.Where(x => x.UserId == userid).SingleOrDefault();
                us.FirstName = HttpContext.Request.Form["fname"];
                us.LastName = HttpContext.Request.Form["lname"];
                us.Phone = HttpContext.Request.Form["phone"];
                us.Address = HttpContext.Request.Form["address"];
                us.Email = HttpContext.Request.Form["mail"];

                ct.Users.Update(us);
                ct.SaveChanges();
            return Redirect("/Home/Trangchu");
        }
    }
}
