using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using System.Windows.Forms;

namespace AutoSkills
{
    public class AutoSkillsSettings : ISettings
    {
        public HotkeyNode attackSkillKey { get; set; } = Keys.T;
        public ToggleNode Enable { get; set; } = new ToggleNode(false);
    }
}
