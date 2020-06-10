//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static CapabilityAspect;
    
    public enum CapabilityAspect : int
    {
        None = 0,

        Contract = 1,

        Host = 2,

        Factory = 3,

        AspectOffset = 16,
    }
    
    public enum CapabilityKind : ulong
    {
        None = 0,
        
        /// <summary>
        /// Load code that has been captured from memory and persisted in hex-text format: <see cref="LoadUriCodeContract"/>
        /// </summary>
        LoadUriCode = 1,

        /// <summary>
        /// <see cref="UriHexArchive"/> 
        /// </summary>
        LoadUriCodeHost = LoadUriCode | (Host << AspectOffset),

        /// <summary>
        /// <see cref="IUriHexArchive"/> 
        /// </summary>
        LoadUriCodeContract = LoadUriCode | (Contract << AspectOffset),

        /// <summary>
        /// <see cref="UriHexArchive.Create(FolderPath)"/>
        /// </summary>
        LoadUriCodeServiceFactory = LoadUriCode | (Factory << AspectOffset),
    }
}