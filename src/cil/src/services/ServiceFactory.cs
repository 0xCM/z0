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

    using Z0.CilSpecs;

    using Dn = dnlib.DotNet;
    using DnLib = dnlib.DotNet.Emit;

    public readonly struct CilServices
    {        
        public static IClrIndexer indexer(Assembly src)
            => ClrIndexer.Create(src);

        public static IEnumerable<CilFunction> decode(Module mod, params MethodInfo[] src)
        {                        
            var dnMod = Dn.ModuleDefMD.Load(mod);
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
                        var mcil = new CilFunction((int)token, 
                            mDef.FullName, 
                            ToSpec(mDef.ImplAttributes), 
                            mDef.Body.Instructions.Map(ToSpec)
                            );
                        mDef.FreeMethodBody();
                        yield return mcil;                           
                    }
                }
            }                                   
        }

        /// <summary>
        /// Converts the dnlib-defined data structure to a Z0-defined replication of the dnlib structure
        /// </summary>
        /// <param name="src">The dnlib source value</param>
        static CilSpecs.MethodImplAttributes ToSpec(Dn.MethodImplAttributes src)
            => (CilSpecs.MethodImplAttributes)src;

        /// <summary>
        /// Converts the dnlib-defined data structure to a Z0-defined replication of the dnlib structure
        /// </summary>
        /// <param name="src">The dnlib source value</param>
        static Instruction ToSpec(DnLib.Instruction src)    
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
        static OpCode ToSpec(DnLib.OpCode src)
            => new OpCode(
                name: src.Name, 
                code: (Code)src.Code, 
                operandType: (OperandType)src.OperandType, 
                flowControl: (FlowControl)src.FlowControl, 
                opCodeType:  (OpCodeType)src.OpCodeType, 
                push: (StackBehaviour)src.StackBehaviourPush, 
                pop: (StackBehaviour)src.StackBehaviourPop
                );                
    }
}