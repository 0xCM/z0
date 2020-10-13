//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    using static DnCilModel;

    using Dn = dnlib.DotNet;
    using DnLib = dnlib.DotNet.Emit;
    using R = System.Reflection;

    public readonly partial struct CilApi
    {
        /// <summary>
        /// Converts the dnlib-defined data structure to a Z0-defined replication of the dnlib structure
        /// </summary>
        /// <param name="src">The dnlib source value</param>
        internal static Instruction ToSpec(DnLib.Instruction src)
            => new Instruction{
                OpCode = ToSpec(src.OpCode),
                Operand = src.Operand,
                Offset = src.Offset,
                Formatted = src.ToString()
            };

        /// <summary>
        /// Converts the dnlib-defined data structure to a Z0-defined replication of the dnlib structure
        /// </summary>
        /// <param name="src">The dnlib source value</param>
        internal static OpCode ToSpec(DnLib.OpCode src)
            => new OpCode(
                name: src.Name,
                code: (Code)src.Code,
                operandType: (OperandType)src.OperandType,
                flowControl: (FlowControl)src.FlowControl,
                opCodeType:  (OpCodeType)src.OpCodeType,
                push: (StackBehaviour)src.StackBehaviourPush,
                pop: (StackBehaviour)src.StackBehaviourPop
                );

        public static IClrIndexer indexer(R.Assembly src)
            => ClrIndexer.create(src);

        public static Option<CilFunction> decode(R.MethodInfo src)
        {
            var mod = src.DeclaringType.Module;
            var dnMod = Dn.ModuleDefMD.Load(mod);
            var types = dnMod.GetTypes();
            foreach(var tDef in types)
            {
                foreach(var mDef in tDef.Methods)
                {
                    if(!mDef.HasBody || !mDef.Body.HasInstructions)
                        continue;

                    var token = mDef.MDToken.Raw;
                    if(token == src.MetadataToken)
                    {
                        var cil = new CilFunction((int)token,mDef.FullName, (R.MethodImplAttributes)mDef.ImplAttributes, mDef.Body.Instructions.Map(ToSpec));
                        mDef.FreeMethodBody();
                        return cil;
                    }
                }
            }
            return Option.none<CilFunction>();
        }

        public static IEnumerable<CilFunction> decode(R.Module module, params MethodInfo[] src)
        {
            var dnMod = Dn.ModuleDefMD.Load(module);
            var types = dnMod.GetTypes();
            var lookup = src.Select(x => ((uint)x.MetadataToken, x)).ToDictionary();

            foreach(var tDef in types)
            {
                foreach(var mDef in tDef.Methods)
                {
                    if(!mDef.HasBody || !mDef.Body.HasInstructions)
                        continue;

                    var token = mDef.MDToken.Raw;
                    if(lookup.ContainsKey(token))
                    {
                        var fx = new CilFunction(token, mDef.FullName, (R.MethodImplAttributes)mDef.ImplAttributes, mDef.Body.Instructions.Map(ToSpec));
                        mDef.FreeMethodBody();
                        yield return fx;
                    }
                }
            }
        }
    }
}