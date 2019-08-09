﻿using System.Linq;
using SenseNet.ContentRepository.i18n;

namespace SenseNet.Portal.OData.Typescript
{
    internal class ResourceWriter
    {
        public static void WriteResourceClasses(System.IO.TextWriter writer)
        {
            writer.WriteLine(@"/**
 * @module Resources
 * @preferred
 * 
 * @description Module for Resource classes. Helps you to reach string resource classes with dot notation.
 *
 * This module is autogenerated from Sense/Net Localization files.
 * ```ts
 * import * as SenseNet from './Scripts/SenseNet'
 *
 * const editActionName = SenseNet.Resources.Actions[""Edit""]
 * ```
 */");

            foreach (var className in SenseNetResourceManager.Current.GetClasses().OrderBy(x => x))
                writer.WriteLine($" export class {className.Replace("-", "")} {{ }}");
        }
    }
}
