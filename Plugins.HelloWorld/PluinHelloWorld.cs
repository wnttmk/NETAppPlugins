using PluginBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plugins.HelloWorld
{
    public class PluinHelloWorld : IPlugin
    {
        public static Guid guid = Guid.Parse("{79BB6BE6-9A4A-4DCD-A622-5A59F66112EB}");
        public Guid PluginId
        {
            get { return guid; }
        }

        public string Run(string args)
        {
            return string.Concat(AppDomain.CurrentDomain.FriendlyName, "(", args, ")-- v3");
        }


        public string Run(string args, Action action)
        {
            action();

            return Run(args);
        }
    }
}
