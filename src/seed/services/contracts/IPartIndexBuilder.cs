//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IPartIndexBuilder : IService
    {
        /// <summary>
        /// Computes the known parts, which excludes those that aren't known, whether they are known unknowables, 
        /// unknown unknowables, outside our search scope or simply missing because of an errant build 
        /// process, a random file deletion algorithm rampaging throgh the environs 'digitale, or any 
        /// unforseen for forseen reason.
        /// </summary>
        PartIndex Build();
    }
}