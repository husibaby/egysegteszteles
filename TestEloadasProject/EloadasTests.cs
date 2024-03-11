using NUnit.Framework;
using EloadasProject;


namespace TestEloadasProject
{
 
    public class EloadasTests
    {
        [Test]
        public void HelyesKimenetEllenorzes()
        {
            Eloadas eloadas = new Eloadas(3,3);
            Assert.That(eloadas.Lefoglal(), Is.True);
        }
        [Test]
        public void HelytelenBemenetekEllenorzes()
        {
            Eloadas eloadas = new Eloadas(3, 3);
            Assert.That(eloadas.SzabadHelyek(), Is.EqualTo(9));
            eloadas.Lefoglal();
            Assert.That(eloadas.SzabadHelyek(), Is.EqualTo(8));
        }

        [Test]
        public void SzelsoertekekTeszteles()
        {
                Eloadas eloadas = new Eloadas(1, 1);
                Assert.That(eloadas.Teli, Is.False);
                eloadas.Lefoglal();
                Assert.That(eloadas.Teli, Is.True);
        }

        [Test]
        public void MindenLehetsegesKimenetTeszteles()
        {
            Eloadas eloadas = new Eloadas(3, 3);
            Assert.Throws<System.ArgumentException>(() => eloadas.Foglalt(0, 0));
            Assert.Throws<System.ArgumentException>(() => eloadas.Foglalt(4, 4));
        }
    }
}