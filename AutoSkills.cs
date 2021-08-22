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
        private Coroutine _mainCoroutine;

        public override bool Initialise()
        {
            Input.RegisterKey(Settings.supportSkillKey);
            _mainCoroutine = new Coroutine(
                MainCoroutine(), this, "EDC");
            Core.ParallelRunner.Run(_mainCoroutine);
            return true;
        }

        private IEnumerator MainCoroutine()
        {
            while (true)
            {
                if (Input.IsKeyDown(Settings.supportSkillKey))
                {
                    yield return Attack();
                }

                yield return new WaitTime(10);
            }
        }

        private IEnumerator Attack()
        {
            yield return Input.KeyPress(Settings.attackSkillKey.Value);
        }
    }
}
