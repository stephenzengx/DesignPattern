﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C1_ChainOfResponsibility
{
    /// <summary>
    /// 采购单：请求类
    /// </summary>
    public class PurchaseRequest
    {
        // 采购金额
        public double Amount { get; set; }
        // 采购单编号
        public string Number { get; set; }
        // 采购目的
        public string Purpose { get; set; }

        public PurchaseRequest(double amount, string number, string purpose)
        {
            Amount = amount;
            Number = number;
            Purpose = purpose;
        }
    }
}
