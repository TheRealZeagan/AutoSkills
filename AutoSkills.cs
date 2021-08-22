using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExileCore;
using ExileCore.PoEMemory.Components;
using ExileCore.PoEMemory.MemoryObjects;
using ExileCore.Shared;
using ExileCore.Shared.Enums;
using ExileCore.Shared.Helpers;
using SharpDX;
using System.Collections;
using System.Diagnostics;
using System.IO;

namespace AutoSkills
{
    public class AutoSkills : BaseSettingsPlugin<AutoSkillsSettings>
    {
        public override async void Render()
        {
            if (Keyboard.IsKeyDown(Keyboard.VK_RBUTTON))
            {
                await Task.Delay(10);
                Keyboard.KeyPress(Settings.attackSkillKey);
            }
        }
    }
}
