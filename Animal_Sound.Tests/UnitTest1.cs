using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animal_Sound.Animals;

namespace Animal_Sound.Tests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void Dog_ShouldMakeCorrectSound()
        {
            var dog = new Dog();
            string expected = "Dog makes sound: Bark";

            // Explicitly specify MSTest Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, dog.MakeSound());
        }

        [TestMethod]
        public void Capybara_ShouldMakeCorrectSound()
        {
            var capybara = new Capybara();
            string expected = "Capybara makes sound: Whistle";

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, capybara.MakeSound());
        }
    }
}