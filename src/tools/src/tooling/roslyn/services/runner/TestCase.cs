//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/OmniSharp/omnisharp-roslyn
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Serialization;

    partial struct ProjectRunner
    {
        [DataContract]
        public sealed class TestCase
        {
            private object localExtensionData;

            private Guid defaultId = Guid.Empty;

            private Guid id;

            private string displayName;

            private string fullyQualifiedName;

            private string source;

            public object LocalExtensionData
            {
                get
                {
                    return localExtensionData;
                }
                set
                {
                    localExtensionData = value;
                }
            }

            [DataMember]
            public Guid Id
            {
                get
                {
                    if (id == Guid.Empty)
                    {
                        if (defaultId == Guid.Empty)
                        {
                            defaultId = GetTestId();
                        }
                        return defaultId;
                    }
                    return id;
                }
                set
                {
                    id = value;
                }
            }

            [DataMember]
            public string FullyQualifiedName
            {
                get
                {
                    return fullyQualifiedName;
                }
                set
                {
                    fullyQualifiedName = value;
                    defaultId = Guid.Empty;
                }
            }

            [DataMember]
            public string DisplayName
            {
                get
                {
                    if (!string.IsNullOrEmpty(displayName))
                    {
                        return displayName;
                    }
                    return FullyQualifiedName;
                }
                set
                {
                    displayName = value;
                }
            }

            [DataMember]
            public Uri ExecutorUri { get; set; }

            [DataMember]
            public string Source
            {
                get
                {
                    return source;
                }
                set
                {
                    source = value;
                    defaultId = Guid.Empty;
                }
            }

            [DataMember]
            public string CodeFilePath { get; set; }

            [DataMember]
            public int LineNumber { get; set; }

            public TestCase()
            {
            }

            public TestCase(string fullyQualifiedName, Uri executorUri, string source)
            {
                FullyQualifiedName = fullyQualifiedName;
                ExecutorUri = executorUri;
                Source = source;
                LineNumber = -1;
            }

            public override string ToString()
            {
                return FullyQualifiedName;
            }

            private Guid GetTestId()
                => Guid.Empty;


        }
    }
}