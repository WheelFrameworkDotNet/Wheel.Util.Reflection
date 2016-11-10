using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Wheel.Core.Exceptions;
using Wheel.Util.Core.Exceptions;

namespace Wheel.Util.Reflection
{
    [TestClass]
    public class ReflectionUtilUT
    {
        public enum Ejemplo { Valor1, Valor2 }
        public class ClaseEjemplo { }

        #region EsPrimitivo

            [TestMethod]
            public void EsPrimitivo_Nulo()
            {
                try
                {
                    ReflectionUtil.EsPrimitivo(null);
                }
                catch (UtilException e)
                {
                    ArgumentNullException ane = e.InnerException as ArgumentNullException;
                    Assert.AreEqual(ArgumentoInvalido.NULO.Descripcion + "\r\nNombre del parámetro: _objeto", ane.Message);
                    return;
                }
                
                Assert.Fail("¡Se esperaba que se lanzara un 'UtilException'!");
            }

            [TestMethod]
            public void EsPrimitivo_CadenaEnDuro()
            {
                Assert.IsTrue("Cadena de Texto".EsPrimitivo());
            }

            [TestMethod]
            public void EsPrimitivo_Enum()
            {
                Assert.IsTrue(Ejemplo.Valor1.EsPrimitivo());
            }

            [TestMethod]
            public void EsPrimitivo_stringArray()
            {
                Assert.IsTrue(ReflectionUtil.EsPrimitivo(new string[] { "valor1", "valor2" }));
            }

            [TestMethod]
            public void EsPrimitivo_StringArray()
            {
                Assert.IsTrue(ReflectionUtil.EsPrimitivo(new String[] { "valor1", "valor2" }));
            }

            [TestMethod]
            public void EsPrimitivo_stringLista()
            {
                Assert.IsTrue(ReflectionUtil.EsPrimitivo(new List<string>() { "valor1", "valor2" }));
            }

            [TestMethod]
            public void EsPrimitivo_StringLista()
            {
                Assert.IsTrue(ReflectionUtil.EsPrimitivo(new List<String>() { "valor1", "valor2" }));
            }

            [TestMethod]
            public void EsPrimitivo_DiccionarioStringstring()
            {
                Assert.IsTrue(ReflectionUtil.EsPrimitivo(new Dictionary<String, string>()));
            }

            [TestMethod]
            public void EsPrimitivo_ClaseEjemplo()
            {
                ClaseEjemplo obj = new ClaseEjemplo();
                Assert.IsFalse(obj.EsPrimitivo());
            }

            [TestMethod]
            public void EsPrimitivo_ClaseEjemploArray()
            {
                Assert.IsFalse(ReflectionUtil.EsPrimitivo(new ClaseEjemplo[0]));
            }

            [TestMethod]
            public void EsPrimitivo_ClaseEjemploLista()
            {
                Assert.IsFalse(ReflectionUtil.EsPrimitivo(new List<ClaseEjemplo>()));
            }

            [TestMethod]
            public void EsPrimitivo_DiccionarioClaseEjemplostring()
            {
                Assert.IsFalse(ReflectionUtil.EsPrimitivo(new Dictionary<ClaseEjemplo, string>()));
            }

            [TestMethod]
            public void EsPrimitivo_DiccionarioStringClaseEjemplo()
            {
                Assert.IsFalse(ReflectionUtil.EsPrimitivo(new Dictionary<String, ClaseEjemplo>()));
            }

        #endregion EsPrimitivo

        #region EsColeccion

            [TestMethod]
            public void EsColeccion_Nulo()
            {
                try
                {
                    ReflectionUtil.EsColeccion(null);
                }
                catch (UtilException e)
                {
                    ArgumentNullException ane = e.InnerException as ArgumentNullException;
                    Assert.AreEqual(ArgumentoInvalido.NULO.Descripcion + "\r\nNombre del parámetro: _objeto", ane.Message);
                    return;
                }

                Assert.Fail("¡Se esperaba que se lanzara un 'UtilException'!");
            }

            [TestMethod]
            public void EsColeccion_CadenaEnDuro()
            {
                Assert.IsFalse("Cadena de Texto".EsColeccion());
            }

            [TestMethod]
            public void EsColeccion_Enum()
            {
                Assert.IsFalse(Ejemplo.Valor1.EsColeccion());
            }

            [TestMethod]
            public void EsColeccion_stringArray()
            {
                Assert.IsTrue(ReflectionUtil.EsColeccion(new string[] { "valor1", "valor2" }));
            }

            [TestMethod]
            public void EsColeccion_StringArray()
            {
                Assert.IsTrue(ReflectionUtil.EsColeccion(new String[] { "valor1", "valor2" }));
            }

            [TestMethod]
            public void EsColeccion_stringLista()
            {
                Assert.IsTrue(ReflectionUtil.EsColeccion(new List<string>() { "valor1", "valor2" }));
            }

            [TestMethod]
            public void EsColeccion_StringLista()
            {
                Assert.IsTrue(ReflectionUtil.EsColeccion(new List<String>() { "valor1", "valor2" }));
            }

            [TestMethod]
            public void EsColeccion_DiccionarioStringstring()
            {
                Assert.IsTrue(ReflectionUtil.EsColeccion(new Dictionary<String, string>()));
            }

            [TestMethod]
            public void EsColeccion_ClaseEjemplo()
            {
                ClaseEjemplo obj = new ClaseEjemplo();
                Assert.IsFalse(obj.EsColeccion());
            }

            [TestMethod]
            public void EsColeccion_ClaseEjemploArray()
            {
                Assert.IsTrue(ReflectionUtil.EsColeccion(new ClaseEjemplo[0]));
            }

            [TestMethod]
            public void EsColeccion_ClaseEjemploLista()
            {
                Assert.IsTrue(ReflectionUtil.EsColeccion(new List<ClaseEjemplo>()));
            }

            [TestMethod]
            public void EsColeccion_DiccionarioClaseEjemplostring()
            {
                Assert.IsTrue(ReflectionUtil.EsColeccion(new Dictionary<ClaseEjemplo, string>()));
            }

            [TestMethod]
            public void EsColeccion_DiccionarioStringClaseEjemplo()
            {
                Assert.IsTrue(ReflectionUtil.EsColeccion(new Dictionary<String, ClaseEjemplo>()));
            }

        #endregion EsColeccion

        #region EsEnumeracion

            [TestMethod]
            public void EsEnumeracion_Nulo()
            {
                try
                {
                    ReflectionUtil.EsEnumeracion(null);
                }
                catch (UtilException e)
                {
                    ArgumentNullException ane = e.InnerException as ArgumentNullException;
                    Assert.AreEqual(ArgumentoInvalido.NULO.Descripcion + "\r\nNombre del parámetro: _objeto", ane.Message);
                    return;
                }

                Assert.Fail("¡Se esperaba que se lanzara un 'UtilException'!");
            }

            [TestMethod]
            public void EsEnumeracion_CadenaEnDuro()
            {
                Assert.IsFalse("Cadena de Texto".EsEnumeracion());
            }

            [TestMethod]
            public void EsEnumeracion_Enum()
            {
                Assert.IsTrue(Ejemplo.Valor1.EsEnumeracion());
            }

            [TestMethod]
            public void EsEnumeracion_stringArray()
            {
                Assert.IsFalse(ReflectionUtil.EsEnumeracion(new string[] { "valor1", "valor2" }));
            }

            [TestMethod]
            public void EsEnumeracion_StringArray()
            {
                Assert.IsFalse(ReflectionUtil.EsEnumeracion(new String[] { "valor1", "valor2" }));
            }

            [TestMethod]
            public void EsEnumeracion_stringLista()
            {
                Assert.IsFalse(ReflectionUtil.EsEnumeracion(new List<string>() { "valor1", "valor2" }));
            }

            [TestMethod]
            public void EsEnumeracion_StringLista()
            {
                Assert.IsFalse(ReflectionUtil.EsEnumeracion(new List<String>() { "valor1", "valor2" }));
            }

            [TestMethod]
            public void EsEnumeracion_DiccionarioStringstring()
            {
                Assert.IsFalse(ReflectionUtil.EsEnumeracion(new Dictionary<String, string>()));
            }

            [TestMethod]
            public void EsEnumeracion_ClaseEjemplo()
            {
                ClaseEjemplo obj = new ClaseEjemplo();
                Assert.IsFalse(obj.EsEnumeracion());
            }

            [TestMethod]
            public void EsEnumeracion_ClaseEjemploArray()
            {
                Assert.IsFalse(ReflectionUtil.EsEnumeracion(new ClaseEjemplo[0]));
            }

            [TestMethod]
            public void EsEnumeracion_ClaseEjemploLista()
            {
                Assert.IsFalse(ReflectionUtil.EsEnumeracion(new List<ClaseEjemplo>()));
            }

            [TestMethod]
            public void EsEnumeracion_DiccionarioClaseEjemplostring()
            {
                Assert.IsFalse(ReflectionUtil.EsEnumeracion(new Dictionary<ClaseEjemplo, string>()));
            }

            [TestMethod]
            public void EsEnumeracion_DiccionarioStringClaseEjemplo()
            {
                Assert.IsFalse(ReflectionUtil.EsEnumeracion(new Dictionary<String, ClaseEjemplo>()));
            }

        #endregion EsEnumeracion

        #region EsDiccionario

            [TestMethod]
            public void EsDiccionario_Nulo()
            {
                try
                {
                    ReflectionUtil.EsDiccionario(null);
                }
                catch (UtilException e)
                {
                    ArgumentNullException ane = e.InnerException as ArgumentNullException;
                    Assert.AreEqual(ArgumentoInvalido.NULO.Descripcion + "\r\nNombre del parámetro: _objeto", ane.Message);
                    return;
                }

                Assert.Fail("¡Se esperaba que se lanzara un 'UtilException'!");
            }

            [TestMethod]
            public void EsDiccionario_CadenaEnDuro()
            {
                Assert.IsFalse("Cadena de Texto".EsDiccionario());
            }

            [TestMethod]
            public void EsDiccionario_Enum()
            {
                Assert.IsFalse(Ejemplo.Valor1.EsDiccionario());
            }

            [TestMethod]
            public void EsDiccionario_stringArray()
            {
                Assert.IsFalse(ReflectionUtil.EsDiccionario(new string[] { "valor1", "valor2" }));
            }

            [TestMethod]
            public void EsDiccionario_StringArray()
            {
                Assert.IsFalse(ReflectionUtil.EsDiccionario(new String[] { "valor1", "valor2" }));
            }

            [TestMethod]
            public void EsDiccionario_stringLista()
            {
                Assert.IsFalse(ReflectionUtil.EsDiccionario(new List<string>() { "valor1", "valor2" }));
            }

            [TestMethod]
            public void EsDiccionario_StringLista()
            {
                Assert.IsFalse(ReflectionUtil.EsDiccionario(new List<String>() { "valor1", "valor2" }));
            }

            [TestMethod]
            public void EsDiccionario_DiccionarioStringstring()
            {
                Assert.IsTrue(ReflectionUtil.EsDiccionario(new Dictionary<String, string>()));
            }

            [TestMethod]
            public void EsDiccionario_ClaseEjemplo()
            {
                ClaseEjemplo obj = new ClaseEjemplo();
                Assert.IsFalse(obj.EsDiccionario());
            }

            [TestMethod]
            public void EsDiccionario_ClaseEjemploArray()
            {
                Assert.IsFalse(ReflectionUtil.EsDiccionario(new ClaseEjemplo[0]));
            }

            [TestMethod]
            public void EsDiccionario_ClaseEjemploLista()
            {
                Assert.IsFalse(ReflectionUtil.EsDiccionario(new List<ClaseEjemplo>()));
            }

            [TestMethod]
            public void EsDiccionario_DiccionarioClaseEjemplostring()
            {
                Assert.IsTrue(ReflectionUtil.EsDiccionario(new Dictionary<ClaseEjemplo, string>()));
            }

            [TestMethod]
            public void EsDiccionario_DiccionarioStringClaseEjemplo()
            {
                Assert.IsTrue(ReflectionUtil.EsDiccionario(new Dictionary<String, ClaseEjemplo>()));
            }

        #endregion EsDiccionario


    }
}
