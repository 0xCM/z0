//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.X
{
    using System;
    using Microsoft.Win32;

    public readonly struct WinReg
    {
        public static string GetStringFromRegistry(string key, string valueName)
        {
            object value = GetValueFromRegistry(RegistryHive.LocalMachine, key, valueName);
            return value as string;
        }

        public static object GetValueFromRegistry(RegistryHive registryHive, string key, string valueName)
        {
            object value = GetValueFromRegistry(registryHive, key, valueName, RegistryView.Registry64);
            if (value == null)
                value = GetValueFromRegistry(registryHive, key, valueName, RegistryView.Registry32);

            return value;
        }

        static object GetValueFromRegistry(RegistryHive registryHive, string key, string valueName, RegistryView view)
        {
            var localKey = RegistryKey.OpenBaseKey(registryHive, view);
            var localKeySub = localKey.OpenSubKey(key);

            object value = localKeySub == null ? null : localKeySub.GetValue(valueName);
            return value;
        }

        public static bool TrySetDWordInRegistry(RegistryHive registryHive, string key, string valueName, uint value)
        {
            var localKey = RegistryKey.OpenBaseKey(registryHive, RegistryView.Registry64);
            var localKeySub = localKey.OpenSubKey(key, writable: true);

            if (localKeySub == null)
            {
                localKey = RegistryKey.OpenBaseKey(registryHive, RegistryView.Registry32);
                localKeySub = localKey.OpenSubKey(key, writable: true);
            }

            if (localKeySub == null)
            {
                return false;
            }

            localKeySub.SetValue(valueName, value, RegistryValueKind.DWord);
            return true;
        }
    }
}