using NUnit.Framework;
using Memento;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMemento()
        {
			Juego juego = new Juego();
			juego.setProgress("15%");
			juego.setCheckpoint(1);

			Caretaker caretaker = new Caretaker();
			Originator originator = new Originator();

			juego.setProgress("40%");
			juego.setCheckpoint(2);
			originator.setEstado(juego);

			juego.setProgress("50%");
			juego.setCheckpoint(3);
			originator.setEstado(juego);

			caretaker.addMemento(originator.guardar()); // ESTADO POSICION 0

			juego.setProgress("70%");
			juego.setCheckpoint(4);
			originator.setEstado(juego);

			caretaker.addMemento(originator.guardar()); // ESTADO POSICION 1

			juego.setProgress("80%");
			juego.setCheckpoint(5);
			originator.setEstado(juego);

			caretaker.addMemento(originator.guardar()); // ESTADO POSICION 2

			originator.setEstado(juego);
			originator.restaurar(caretaker.getMemento(1));

			juego = originator.getEstado();
			Assert.AreEqual("70%",juego.toString());
        }
    }
}