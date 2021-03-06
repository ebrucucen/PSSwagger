// Copyright (c) Microsoft Corporation. All rights reserved.

// Licensed under the MIT license.
namespace PSSwagger.LTF.Lib.Models
{
    /// <summary>
    /// Contains metadata for a single parameter.
    /// </summary>
    public class ParameterData
    {
        /// <summary>
        /// Name of the parameter when calling a certain operation
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Name of the parameter when serialized as JSON.
        /// </summary>
        public string JsonName { get; set; }

        /// <summary>
        /// Type of this parameter.
        /// </summary>
        public RuntimeTypeData Type { get; set; }
    }
}