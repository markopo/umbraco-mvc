using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco;
using Umbraco.Core;
using Umbraco.Web;
using umbraco.NodeFactory;

namespace UmbracoTest.Extensions
{
    [Serializable]
    public class FlattenProperty
    {
        public string Alias { get; set; }
        public string Value { get; set; }
    }

    public static class UmbracoExtensions
    {
        public static List<FlattenProperty> ToAliasValues(this umbraco.NodeFactory.Properties props)
        {
            var list = new List<FlattenProperty>(); 
            foreach(Property p in props)
            {
                list.Add(new FlattenProperty
                {
                    Alias = p.Alias,
                    Value = p.Value
                }); 
            }

            return list; 
        }

    }
}