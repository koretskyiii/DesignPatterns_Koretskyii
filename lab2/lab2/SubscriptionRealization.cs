﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public abstract class SubscriptionRealization
    {
        public abstract Subscription CreateSubscription(string type, int period);
    }
}
