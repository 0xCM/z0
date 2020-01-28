//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public static class RootX
    {

        public static PrimalKind PrimalKind(this MonikerSegment ms)
        {
            const PrimalIndicator i = PrimalIndicator.Signed;
            const PrimalIndicator u = PrimalIndicator.Unsigned;
            const PrimalIndicator f = PrimalIndicator.Float;

            switch(ms.SegmentWidth)
            {
                case FixedWidth.W8:
                    if(ms.Indicator ==  i)
                        return Z0.PrimalKind.I8;
                    else if(ms.Indicator == u)
                        return Z0.PrimalKind.U8;
                    else
                        throw new Exception($"indicator {ms.Indicator} unrecognized for a fixed width of 8");

                case FixedWidth.W16:
                    if(ms.Indicator == i)
                        return Z0.PrimalKind.I16;
                    else if(ms.Indicator == u)
                        return Z0.PrimalKind.U16;
                    else
                        throw new Exception($"indicator {ms.Indicator} unrecognized for a fixed width of 16");

                case FixedWidth.W32:
                    if(ms.Indicator ==  i)
                        return Z0.PrimalKind.I32;
                    else if(ms.Indicator == u)
                        return Z0.PrimalKind.U32;
                    else if(ms.Indicator == f)
                        return Z0.PrimalKind.F32;
                    else
                        throw new Exception($"indicator {ms.Indicator} unrecognized for a fixed width of 32");

                case FixedWidth.W64:
                    if(ms.Indicator ==  i)
                        return Z0.PrimalKind.I64;
                    else if(ms.Indicator == u)
                        return Z0.PrimalKind.U64;
                    else if(ms.Indicator == f)
                        return Z0.PrimalKind.F64;
                    else
                        throw new Exception($"indicator {ms.Indicator} unrecognized for a fixed width of 64");
                default:
                    throw new Exception($"Width {ms.SegmentWidth} unrecognized");
            }            
        }

        public static bool Designator(this Assembly a, out IAssemblyDesignator designator)
        {
            designator = null;
            var t = a.GetTypes().Where(x => !x.IsAbstract && x.GetInterfaces().Contains(typeof(IAssemblyDesignator))).FirstOrDefault();
            if(t != null)
            {
                designator = (IAssemblyDesignator)Activator.CreateInstance(t);
                return true;
            }
            return false;            
        }

        public static IOperationCatalog OperationCatalog(this Assembly a)
        {
            if(a.Designator(out var d))
            {
                return d.Catalog;
            }
            else 
                return new EmptyCatalog();
        }

        public static string Format(this PrimalIndicator src)
            => $"{(char)src}";

        public static string Format(this FixedWidth src)
            => $"{(int)src}";

    }
}