using System.Reflection;

namespace MyAttrib
{
    public partial class Form1 : Form
    {
        private List<Type> heroTypes;
        private object selectedHero;

        public Form1()
        {


            InitializeComponent();

            heroTypes = Assembly.GetExecutingAssembly().GetTypes()
                 .Where(t => t.GetCustomAttributes(typeof(HeroAttribute), false).Any())
                 .ToList();

            heroListBox.Items.AddRange(heroTypes.Select(t => t.Name).ToArray());

        }

        private void heroListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (heroListBox.SelectedIndex == -1) return;
            var selectedHeroType = heroTypes[heroListBox.SelectedIndex];
            selectedHero = Activator.CreateInstance(selectedHeroType);

            var skillMethods = selectedHeroType.GetMethods()
                .Where(m => m.GetCustomAttributes(typeof(SkillAttribute), false).Any())
                 .ToList();

            skillListBox.Items.Clear();
            skillListBox.Items.AddRange(skillMethods.Select(m => m.Name).ToArray());
        }

        private void skillListBox_DoubleClick(object sender, EventArgs e)
        {
            if (skillListBox.SelectedIndex == -1) return;

            var selectedSkillMethod = selectedHero.GetType().GetMethod(skillListBox.SelectedItem.ToString());

            selectedSkillMethod?.Invoke(selectedHero, null);    
        }
    }
    public class HeroAttribute : Attribute
    {

    }
    public class SkillAttribute : Attribute
    {

    }



}
