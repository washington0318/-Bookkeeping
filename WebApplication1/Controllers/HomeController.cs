using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Random ran = new Random();
            var model = new List<Myclass>();
            Myclass note;
            for (int i = 0; i <= 200; i++)
            {
                note = new Myclass();
                int randnumber = ran.Next(2);//0、1、2
                if (randnumber != 1)
                {
                    note.Type = "支出";
                }
                else
                {
                    note.Type = "收入";
                }
                string year = DateTime.Now.Year.ToString();
                var month = ran.Next(12);
               
                //亂數範圍(日期)
                Random day = new Random();
                int MinValue = 1;
                int MaxValue = 30;
                var day1 = ran.Next(MinValue, MaxValue).ToString();
               //目前缺少時間變化

                note.Date = year +"/"+ month + "/"+day1;
                //note.Date = DateTime.Now.AddDays((ran.Next(3650)));            
                note.Money = ran.Next(1000);
                model.Add(note);
            }
            return View(model);
        }

            public ActionResult About()
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }

            public ActionResult Contact()
            {
                ViewBag.Message = "Your contact page.";

                return View();
            }
        }
 }
