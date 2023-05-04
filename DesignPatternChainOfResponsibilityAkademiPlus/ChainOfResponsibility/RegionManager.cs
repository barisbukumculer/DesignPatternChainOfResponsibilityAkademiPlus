﻿using DesignPatternChainOfResponsibilityAkademiPlus.DAL;
using DesignPatternChainOfResponsibilityAkademiPlus.Models;

namespace DesignPatternChainOfResponsibilityAkademiPlus.ChainOfResponsibility
{
    public class RegionManager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 350000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Bölge Müdürü Yeliz Güneşli";
                customerProcess.Description = "Müşterinin talep ettiği tutar müşteriye bölge müdürü tarafından ödenmiştir.";
                context.Add(customerProcess);
                context.SaveChanges();
            }
            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Bölge Müdürü Yeliz Güneşli";
                customerProcess.Description = "Müşterinin talep ettiği tutar bankanın günlük para çekme limitinin üzerinde olduğu için müşteriye ödeme yapılamadı.";
                context.Add(customerProcess);
                context.SaveChanges();
               
            }
        }
    }
}
