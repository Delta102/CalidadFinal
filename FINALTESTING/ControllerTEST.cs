using Calidad20222.web.Controllers;
using Calidad20222.web.Helper;
using Calidad20222.web.Models;
using Calidad20222.web.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FINALTESTING
{
    public class ControllerTEST
    {
        PokerService pokerService;

        [Test]
        public void CartaMayorTest01() {

            List<Carta> lista = new List<Carta> (){ 
                new Carta{ 
                    Numero=10,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=2,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero=3,
                    Palo = "TREBOL"
                },

                new Carta{
                    Numero=5,
                    Palo = "COCO"
                },

                new Carta{ 
                    Numero=6,
                    Palo ="ESPADA"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("CARTA MAYOR", result);
        }

        [Test]
        public void CartaMayorTest02()
        {

            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=1,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=2,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero=3,
                    Palo = "TREBOL"
                },

                new Carta{
                    Numero=5,
                    Palo = "COCO"
                },

                new Carta{
                    Numero=6,
                    Palo ="ESPADA"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("CARTA MAYOR", result);
        }


        [Test]
        public void DobleTest01()
        {

            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=10,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=10,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero=3,
                    Palo = "TREBOL"
                },

                new Carta{
                    Numero=5,
                    Palo = "COCO"
                },

                new Carta{
                    Numero=6,
                    Palo ="ESPADA"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("DOBLE", result);
        }

        [Test]
        public void DobleTest02()
        {

            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=9,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=10,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero=3,
                    Palo = "TREBOL"
                },

                new Carta{
                    Numero=3,
                    Palo = "COCO"
                },

                new Carta{
                    Numero=6,
                    Palo ="ESPADA"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("DOBLE", result);
        }


        [Test]
        public void DobleParejaTest01()
        {

            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=10,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=10,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero=3,
                    Palo = "TREBOL"
                },

                new Carta{
                    Numero=3,
                    Palo = "COCO"
                },

                new Carta{
                    Numero=6,
                    Palo ="ESPADA"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("DOBLE PAREJA", result);
        }

        [Test]
        public void DobleParejaTest02()
        {

            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=1,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=8,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero=8,
                    Palo = "TREBOL"
                },

                new Carta{
                    Numero=3,
                    Palo = "COCO"
                },

                new Carta{
                    Numero=3,
                    Palo ="ESPADA"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("DOBLE PAREJA", result);
        }


        [Test]
        public void TrioTest01()
        {
            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=10,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=10,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero=10,
                    Palo = "TREBOL"
                },

                new Carta{
                    Numero=5,
                    Palo = "COCO"
                },

                new Carta{
                    Numero=6,
                    Palo ="ESPADA"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("TRIO", result);
        }

        [Test]
        public void TrioTest02()
        {
            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=10,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=10,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero=10,
                    Palo = "TREBOL"
                },

                new Carta{
                    Numero=5,
                    Palo = "COCO"
                },

                new Carta{
                    Numero=6,
                    Palo ="ESPADA"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("TRIO", result);
        }

        [Test]
        public void EscaleraTest01()
        {
            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=10,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=9,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero=8,
                    Palo = "TREBOL"
                },

                new Carta{
                    Numero=7,
                    Palo = "COCO"
                },

                new Carta{
                    Numero=6,
                    Palo ="ESPADA"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA", result);
        }

        [Test]
        public void EscaleraTest02()
        {
            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=5,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=7,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero=8,
                    Palo = "TREBOL"
                },

                new Carta{
                    Numero=6,
                    Palo = "COCO"
                },

                new Carta{
                    Numero=9,
                    Palo ="ESPADA"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA", result);
        }

        [Test]
        public void ColorTest01()
        {
            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=2,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=6,
                    Palo = "CORAZON"
                },
                new Carta{
                    Numero=8,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=10,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=13,
                    Palo ="CORAZON"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("COLOR", result);
        }

        [Test]
        public void ColorTest02()
        {
            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=13,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero= 9,
                    Palo = "CORAZON"
                },
                new Carta{
                    Numero=8,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=10,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=13,
                    Palo ="CORAZON"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("COLOR", result);
        }


        [Test]
        public void FullTest01()
        {
            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=1,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=1,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero=1,
                    Palo = "ESPADO"
                },

                new Carta{
                    Numero=10,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=10,
                    Palo ="ESPADA"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("FULL", result);
        }

        [Test]
        public void FullTest02()
        {
            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=6,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=6,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero=6,
                    Palo = "ESPADO"
                },

                new Carta{
                    Numero=9,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=9,
                    Palo ="ESPADA"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("FULL", result);
        }

        [Test]
        public void PokerTest01()
        {
            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=1,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=1,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero=1,
                    Palo = "ESPADO"
                },

                new Carta{
                    Numero=1,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=10,
                    Palo ="ESPADA"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("POKER", result);
        }

        [Test]
        public void PokerTest02()
        {
            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=5,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=5,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero=5,
                    Palo = "ESPADO"
                },

                new Carta{
                    Numero=5,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=5,
                    Palo ="ESPADA"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("POKER", result);
        }

        [Test]
        public void EscaleraRealTest01()
        {
            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=1,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=13,
                    Palo = "CORAZON"
                },
                new Carta{
                    Numero=12,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=11,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=10,
                    Palo ="CORAZON"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA REAL", result);
        }

        [Test]
        public void EscaleraRealTest02()
        {
            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=1,
                    Palo = "ESPADA"
                },

                new Carta{
                    Numero=13,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero=12,
                    Palo = "ESPADA"
                },

                new Carta{
                    Numero=11,
                    Palo = "ESPADA"
                },

                new Carta{
                    Numero=10,
                    Palo ="ESPADA"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA REAL", result);
        }

        [Test]
        public void EscaleraColorTest01()
        {
            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=7,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=6,
                    Palo = "CORAZON"
                },
                new Carta{
                    Numero=9,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=10,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=8,
                    Palo ="CORAZON"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA COLOR", result);
        }

        [Test]
        public void EscaleraColorTest02()
        {
            List<Carta> lista = new List<Carta>(){
                new Carta{
                    Numero=7,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=6,
                    Palo = "CORAZON"
                },
                new Carta{
                    Numero=9,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=10,
                    Palo = "CORAZON"
                },

                new Carta{
                    Numero=8,
                    Palo ="CORAZON"
                }
            };

            pokerService = new PokerService();

            var result = pokerService.GetJugada(lista);
            Assert.AreEqual("ESCALERA COLOR", result);
        }
    }
}
