using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DemoMvcApplication_Entity;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace DemoMvcApplication.Controllers
{
    public class RegistrationController : Controller
    {
        //
        // GET: /Registration/
        private readonly string Baseurl = "http://localhost:49967/";



        public async Task<ActionResult> Index()
        {
            List<RegistrationEntity> regInfo = new List<RegistrationEntity>();

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage Res = await client.GetAsync("api/RegApi/Get");


                if (Res.IsSuccessStatusCode)
                {

                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;


                    regInfo = JsonConvert.DeserializeObject<List<RegistrationEntity>>(EmpResponse);

                }

                return View(regInfo);
            }
        }

        public ActionResult Create()
        {
           return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(RegistrationEntity entity)
        {
            using (var client = new HttpClient())
            {
               
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
              
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync("api/RegApi/Insert", entity);

                if (response.IsSuccessStatusCode)
                {
                  
                    var result = response.Content.ReadAsStringAsync().Result;
                    return RedirectToAction("Index");
                 }
              
                return View();
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            RegistrationEntity regInfo = new RegistrationEntity();

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage Res = await client.GetAsync("api/RegApi/GetByid/"+id);


                if (Res.IsSuccessStatusCode)
                {

                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;


                    regInfo = JsonConvert.DeserializeObject<RegistrationEntity>(EmpResponse);

                }

                return View(regInfo);
            }

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Edit(RegistrationEntity entity)
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.PutAsJsonAsync("api/RegApi/Update/", entity);


                if (Res.IsSuccessStatusCode)
                {

                    var Response = Res.Content.ReadAsStringAsync().Result;


                   var isupdated  = JsonConvert.DeserializeObject<bool>(Response);

                }

                return RedirectToAction("Index");
            }


            return View(entity);
        }



        public async Task<ActionResult> Delete(int id)
        {
             RegistrationEntity regInfo = new RegistrationEntity();

             using (var client = new HttpClient())
             {

                 client.BaseAddress = new Uri(Baseurl);

                 client.DefaultRequestHeaders.Clear();

                 client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                 HttpResponseMessage Res = await client.GetAsync("api/RegApi/GetByid/" + id);


                 if (Res.IsSuccessStatusCode)
                 {

                     var EmpResponse = Res.Content.ReadAsStringAsync().Result;


                     regInfo = JsonConvert.DeserializeObject<RegistrationEntity>(EmpResponse);

                 }
             }

            return View(regInfo);
        }
        [HttpPost]
        public async Task<ActionResult> Delete(RegistrationEntity entity)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                 HttpResponseMessage Res = await client.DeleteAsync("api/RegApi/Delete/" + entity.Id);
               if (Res.IsSuccessStatusCode)
                {

                  var Response = Res.Content.ReadAsStringAsync().Result; 
                    var isdeleted = JsonConvert.DeserializeObject<bool>(Response);
                  if (isdeleted)
                      return RedirectToAction("Index");
                }
            }


            return View();
        }


    }
}
