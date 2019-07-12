using System;
using System.Collections.Generic;
using System.Text;

namespace BikeReg
{
    static class BikeRegHelpers
    {
        public static bool IsRemovedRegistration(this BikeRegEventEntry entry) => entry.CategoryName != "Removed Registration";
        public static bool IsRefundedRegistration(this BikeRegEventEntry entry) => entry.CategoryName != "Refunded Registration";
    }
}
