//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    class ModuleState
    {
        public static ModuleState Create()
            => new ModuleState();
        
        ModuleState()
        {
            TypeData = new Type[19]{
            typeof(void),       //0
            typeof(object),     //1
            typeof(DBNull),     //2
            typeof(bool),       //3
            typeof(char),       //4
            typeof(sbyte),      //5
            typeof(byte),       //6
            typeof(short),      //7
            typeof(ushort),     //8
            typeof(int),        //9
            typeof(uint),       //10
            typeof(long),       //11
            typeof(ulong),      //12
            typeof(float),      //13
            typeof(double),     //14
            typeof(decimal),    //15
            typeof(DateTime),   //16
            typeof(void),       //17
            typeof(string),     //18
            };        

        }
    
        Type[] TypeData {get;}
        
        public ReadOnlySpan<Type> Types 
            => TypeData;
    
    }
    
    [ApiHost("api")]
    public partial class Memories : IApiHost<Memories>
    {
        public Memories()
        {
            Module = ModuleState.Create();
        }

        internal readonly ModuleState Module;
        
    }

    public static partial class XMem    
    {

    }

    public static partial class XTend
    {
        
    }
}