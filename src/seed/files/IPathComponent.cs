//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    // /// <summary>
    // /// Characterizes part of a file/uri path
    // /// </summary>
    // public interface IPathComponent : IIdentification
    // {
    //     /// <summary>
    //     /// The path component delimiter
    //     /// </summary>
    //     const char Separator = '/';

    //     /// <summary>
    //     /// The component name
    //     /// </summary>
    //     string  Name {get;} 

    //     /// <summary>
    //     /// Changes the name of the component model, not the physical entity it represents
    //     /// </summary>
    //     /// <param name="name">The new component name</param>
    //     /// <remarks>The default implementation is impotent; this pattern prevents reifications from breaking 
    //     /// if the rename operation is not implemented</remarks>
    //     IPathComponent Rename(string name)
    //         => this;

    //     /// <summary>
    //     /// Establishes an equivalence between the component name and its identity
    //     /// </summary>
    //     string IIdentified.IdentityText 
    //         => Name;
    // }

    // /// <summary>
    // /// Characterizes an F-bound polymorphic path component reification
    // /// </summary>
    // /// <typeparam name="T">The reification type</typeparam>
    // public interface IPathComponent<T> : IPathComponent, IIdentification<T>
    //     where T : IPathComponent<T>, new()
    // {        
    //     /// <summary>
    //     /// The empty
    //     /// </summary>
    //     static T Empty => new T();

    //     /// <summary>
    //     /// Changes the name of the component model, not the physical entity it represents
    //     /// </summary>
    //     /// <param name="name">The new component name</param>
    //     [MethodImpl(Inline)]
    //     new T Rename(string name)        
    //         => (T)(((IPathComponent)Empty)).Rename(name);
    // }

    // public interface IFileExtension : IPathComponent
    // {
    //     string SearchPattern
    //     {
    //         [MethodImpl(Inline)]
    //         get => string.IsNullOrWhiteSpace(Name) ? "*.*" : $"*.{this}";
    //     }
        
    // }

    // public interface IFileExtension<T> : IFileExtension, IPathComponent<T>
    //     where T : IFileExtension<T>, new()
    // {
        
    // }

    // public interface IFolderPath : IPathComponent
    // {
        
    // }

    // public interface IFolderPath<T> : IFolderPath, IPathComponent<T>
    //     where T : IFolderPath<T>, new()
    // {

    // }

}