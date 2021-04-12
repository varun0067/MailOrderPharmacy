using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using RefillMSProject.DTO;
using RefillMSProject.Models;
using RefillMSProject.RefillRepository;

namespace RefillMSProject.RefillService
{
    public class RefillService:IRefillService
    {
        private readonly IRefillRepository _repository;

        public RefillService(IRefillRepository repository)
        {
            _repository = repository;
        }

        public bool CreateRefillOrders(RefillOrderDTO refillOrder)
        {
            return _repository.CreateRefillOrders(refillOrder);
        }

        public List<RefillOrder> GetRefillOrders(int subscriptionId)
        {
            return _repository.GetRefillOrders(subscriptionId);
        }
        public List<RefillOrder> GetRefillDuesAsOfDate(int subscriptionId, DateTime fromDate)
        {
            return _repository.GetRefillDuesAsOfDate(subscriptionId, fromDate);
        }
        public bool RequestAdhocRefill(int subscriptionId, int refillId)
        {
            return _repository.RequestAdhocRefill(subscriptionId, refillId);
        }
        public bool CheckPendingPaymentStatus(int subscriptionId)
        {
            return _repository.CheckPendingPaymentStatus(subscriptionId);
        }
        //public int GetRefillStatus(int subscriptionID)
        //{

        //        var res = _repository.GetRefillStatus(subscriptionID);
        //        return res;


        //}
        //public int GetRefillDuesAsOfDate(int id, DateTime date)
        //{
        //    //HttpClient client = new HttpClient();
        //    //client.BaseAddress = new Uri("");
        //    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //    //HttpResponseMessage response = client.GetAsync("/api/Subscription/getPrescriptionCourse/" + id).Result;
        //    //int course = response.Content.ReadAsAsync<int>().Result;

        //    //HttpResponseMessage resp = client.GetAsync("/api/Subscription/getOccurrenceandDate/" + id).Result;
        //    //var refillOccurence = response.Content.ReadAsAsync<MemberSubscriptionDTO>().Result;

        //    int course = 30;
        //    int occurence = 7;
        //    DateTime subdate = new DateTime(2021, 04, 01);
        //    int days = (date - subdate).Days;

        //    int remDue = (course / occurence) - (days / occurence);
        //    return remDue;

        //}

        //public int RequestAdhocRefill(int id, string location)
        //{
        //    bool availability;
        //    int qty = _repository.GetQty(id);
        //    int drugID = _repository.GetDrugID(id);

        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("http://localhost:60177");
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //    HttpResponseMessage response = client.GetAsync("/api/Drugs/GetAvailability/" + drugID + "/" + location + "/" + qty).Result;
        //    availability = response.Content.ReadAsAsync<bool>().Result;
        //    if (availability)
        //    {
        //        return (_repository.GetRefillOrderID(id));
        //    }
        //    else
        //        return 0;
        //}
    }
}
