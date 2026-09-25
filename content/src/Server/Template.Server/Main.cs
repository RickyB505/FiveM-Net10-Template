using System;
using System.Text;
using System.Text.Json;

using CitizenFX.FiveM.Server;
using CitizenFX.FiveM.Shared.Script;

namespace Template.Server;

public class Main : IScript
{
    public void Initialize()
    {
        API.Log.Info("Template.Server initialized");
    }
}
