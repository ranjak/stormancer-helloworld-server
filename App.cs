using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stormancer;
using Stormancer.Core;

namespace tutorial_helloworld
{
    public class App
    {
      public void Run(IAppBuilder builder)
      {
      builder.SceneTemplate("hello", scene =>
      {
        scene.Connected.Add(peer =>
        {
          peer.Send("msg", "Hello World!");
          return Task.FromResult(true);
        });
      });
      }
    }
}
