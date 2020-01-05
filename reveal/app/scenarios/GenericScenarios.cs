namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using static zfunc;

    class GenericScenarios
    {
        public static MethodDisassembly[] DeconstructGeneric(Type host, string[] opnames, Type[] typeargs)
        {
            var open = host.Methods().Public().OpenGeneric().Where(m => opnames.Contains(m.Name));
            var closed = from om in open
                         from t in typeargs
                         let def = om.GetGenericMethodDefinition()
                         let gm = def.MakeGenericMethod(t)
                         select gm;
            var deconstructed = Deconstructor.Deconstruct(closed);
            deconstructed.Emit("ginx");
            return deconstructed;
        }


        static IEnumerable<MethodInfo> CloseOpenGenerics(IEnumerable<MethodInfo> open, IEnumerable<Type> args)
            =>  from om in open
                from t in args
                let def = om.GetGenericMethodDefinition()
                let gm = def.MakeGenericMethod(t)
                select gm;

        /// <summary>
        /// Specifies the set of unsigned primal integer types
        /// </summary>
        public static Type[] Primitives =>
            new Type[]{
                typeof(byte), typeof(ushort), typeof(uint), typeof(ulong),
                typeof(sbyte), typeof(short), typeof(int), typeof(long),
                typeof(float),typeof(double)
                };

        public static MethodDisassembly[] Gmath()
        {
            var opnames = set("add", "sub", "mul", "idiv", "mod");
            var unopnames = set("negate","inc","dec");

            var closedBinOps = CloseOpenGenerics(gmath.BinOps().Where(m => opnames.Contains(m.Name)), Primitives);
            var closedUnaryOps = CloseOpenGenerics(gmath.UnaryOps().Where(m => unopnames.Contains(m.Name)), Primitives);
            var closedOps = closedBinOps.Union(closedUnaryOps);
            
            var deconstructed = Deconstructor.Deconstruct(closedOps);
            deconstructed.Emit("gmath");
            return deconstructed;

        }

    }

}