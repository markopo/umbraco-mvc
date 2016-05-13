using System;
using Umbraco;
using Umbraco.Core;
using Umbraco.Web;
using umbraco.NodeFactory;

namespace UmbracoTest.Helpers
{
    public class UmbracoHelper
    {

        public static Node GetRootNode()
        {
            var rootNode = new Node(-1);
            return rootNode; 
        }

        public static Node GetHomeNode()
        {
            return GetRootNode().ChildrenAsList[0] as Node; 
        }

    }
}