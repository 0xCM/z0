//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ClrTools
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static FileSystem;

    public interface IFileModule
    {
        FileName Name {get;}


        Extension Ext {get;}
    }
    
    public interface INativeModule : IFileModule
    {

    }
    
    public interface IManagedModule : IFileModule
    {

    }

    public interface IMixedModule : INativeModule, IManagedModule
    {

    }

    
    public interface IDynamicLib : IFileModule
    {
        Extension IFileModule.Ext 
            => ext("dll");
    }

    public interface IStaticLib : IFileModule
    {
        Extension IFileModule.Ext 
            => ext("lib");
        
    }

    public interface IExecutable : IFileModule
    {
        Extension IFileModule.Ext 
            => ext("exe");        
    }

    public interface IExecutable<T> : IExecutable
        where T : struct, IExecutable<T>
    {
        
    }

    public interface IScript
    {
        
    }

    public readonly struct ClrTool : IExecutable<ClrTool>
    {
        public FileName Name {get;}
        
    }

    public readonly struct Libraries
    {


    }


    public readonly struct Projects
    {

    }

    public readonly struct CppProject
    {


    }

    public readonly struct CsProject
    {


    }

    public readonly struct Production<S,T>
    {


    }
}