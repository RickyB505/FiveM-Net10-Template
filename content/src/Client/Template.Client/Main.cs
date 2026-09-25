using System;
using System.Text;
using System.Text.Json;

using CitizenFX.FiveM.Client;
using CitizenFX.FiveM.Shared.Script;

namespace Template.Client;

public class Main : IScript
{
    public void Initialize()
    {
        API.Log.Info("Template.Client initialized");
    }
}