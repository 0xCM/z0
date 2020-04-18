﻿//-------------------------------------------------------------------------------------------
// OSS developed by Chris Moore and licensed via MIT: https://opensource.org/licenses/MIT
// This license grants rights to merge, copy, distribute, sell or otherwise do with it 
// as you like. But please, for the love of Zeus, don't clutter it with regions.
//-------------------------------------------------------------------------------------------
namespace Meta.Core
{
    using System;
    using System.Linq;

    using Z0;
    using static Z0.Seed;
    using static Z0.Memories;
    using static Z0.XPressive;
    using static Z0.XFunc;

    public class StandardOperators 
    {    
        public static NotNullOperator IsNotNull => new NotNullOperator();
        
        public static IsNullOperator IsNull => new IsNullOperator();
        
        public static FalseOperator False => new FalseOperator();
        
        public static TrueOperator True => new TrueOperator();
        
        public static EqualOperator Equal => new EqualOperator();
        
        public static NotEqualOperator NotEqual => new NotEqualOperator();
        
        public static GreaterThanOperator GreaterThan => new GreaterThanOperator();
        
        public static LessThanOperator LessThan => new LessThanOperator();
        
        public static GreaterThanOrEqualOperator GreaterThanOrEqual => new GreaterThanOrEqualOperator();
        
        public static LessThanOrEqualOperator LessThanOrEqual => new LessThanOrEqualOperator();
        
        public static AndOperator And => new AndOperator();
        
        public static OrOperator Or => new OrOperator();
    }

    public sealed class GreaterThanOperator : ComparisonOperator<GreaterThanOperator>
    {
        internal GreaterThanOperator()
            : base("gt", ">")
        { 

        }
    }

    public sealed class LessThanOperator : ComparisonOperator<LessThanOperator>
    {
        internal LessThanOperator()
            : base("lt", "<")
        { 

        }
    }

    public sealed class GreaterThanOrEqualOperator : ComparisonOperator<GreaterThanOrEqualOperator>
    {
        internal GreaterThanOrEqualOperator()
            : base("gteq", ">=")
        { 

        }
    }

    public sealed class LessThanOrEqualOperator : ComparisonOperator<LessThanOrEqualOperator>
    {
        internal LessThanOrEqualOperator()
            : base("lteq", "<=")
        { 

        }
    }
}
