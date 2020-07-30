//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;

    using Z0.Dac;    
    using Z0.MS;
    
    public class AppDomainBuilder : IAppDomainData
    {
        private readonly SOSDac _sos;

        private readonly AppDomainStoreData _appDomainStore;

        private AppDomainData _appDomainData;

        public ulong SharedDomain 
            => _appDomainStore.SharedDomain;

        public ulong SystemDomain 
            => _appDomainStore.SystemDomain;

        public int AppDomainCount 
            => _appDomainStore.AppDomainCount;

        public IAppDomainHelpers Helpers { get; }

        public string? Name
        {
            get
            {
                if (SharedDomain == Address)
                    return "Shared Domain";

                if (SystemDomain == Address)
                    return "System Domain";

                return _sos.GetAppDomainName(Address);
            }
        }

        public int Id 
            => _appDomainData.Id;
 
        public ulong Address { get; private set; }

        public AppDomainBuilder(SOSDac sos, IAppDomainHelpers helpers)
        {
            _sos = sos;
            Helpers = helpers;

            _sos.GetAppDomainStoreData(out _appDomainStore);
        }

        public bool Init(ulong address)
        {
            Address = address;
            return _sos.GetAppDomainData(Address, out _appDomainData);
        }
    }
}