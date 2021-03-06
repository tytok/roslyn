﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Composition;
using Microsoft.CodeAnalysis.Host;
using Microsoft.CodeAnalysis.Host.Mef;

namespace Microsoft.VisualStudio.LanguageServices.LiveShare.Client.LocalForwarders
{
    [ExportLanguageServiceFactory(typeof(ISyntaxTreeFactoryService), StringConstants.CSharpLspLanguageName), Shared]
    internal class CSharpLspSyntaxTreeFactoryServiceFactory : ILanguageServiceFactory
    {
        [ImportingConstructor]
        public CSharpLspSyntaxTreeFactoryServiceFactory()
        {
        }

        public ILanguageService CreateLanguageService(HostLanguageServices languageServices)
        {
            return languageServices.GetOriginalLanguageService<ISyntaxTreeFactoryService>();
        }
    }
}
