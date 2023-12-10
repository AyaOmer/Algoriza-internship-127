using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Models;

namespace Vezeeta.DTOs
{
    public class DiscountDTO
    {

        //string discountCode, int NoOfReq, discountType type, float value

        public string discountCode {  get; set; }
        public int NoOfReq {  get; set; }
        public discountType discountType { get; set; }
        public int value {  get; set; }
    }
}
