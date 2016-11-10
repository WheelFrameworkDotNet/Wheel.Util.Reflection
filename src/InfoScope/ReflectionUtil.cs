using System;
using System.Reflection;
using Wheel.Core.Exceptions;
using Wheel.Util.Core.Exceptions;

namespace Wheel.Util.Reflection.InfoScope
{
    /// <summary>
    /// Utilitario de reflexión con alcance de Info.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <h2 class="groupheader">Registro de versiones</h2>
    ///         <ul>
    ///             <li>1.0.0</li>
    ///             <table>
    ///                 <tr style="font-weight: bold;">
    ///                     <td>Autor</td>
    ///                     <td>Fecha</td>
    ///                     <td>Descripción</td>
    ///                 </tr>
    ///                 <tr>
    ///                     <td>Marcos Abraham Hernández Bravo.</td>
    ///                     <td>07/11/2016</td>
    ///                     <td>Versión Inicial.</td>
    ///                 </tr>
    ///             </table>
    ///         </ul>
    ///     </para>
    /// </remarks>
    public static class ReflectionUtil
    {
        /// <summary>
        /// Comprueba si una propiedad es de tipo creado por el usuario (no primitivo) o de C#(primitivo).
        /// Llama a TypeScope con la PropertyType de la propiedad.
        /// <example>
        ///     bool a = false;                 --> Primitivo
        ///     string a = "Hola Mundo";                 --> Primitivo
        ///     String a = String.Empty;                 --> Primitivo
        ///     UsuarioTO a = new UsuarioTO();  --> No primitivo.
        /// </example>
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_propiedad">Propiedad a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsPrimitivo(this PropertyInfo _propiedad)
        {
            try
            {
                if (_propiedad == null)
                {
                    throw new ArgumentNullException("_propiedad", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.EsPrimitivo(_propiedad.PropertyType);
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si una propiedad es de tipo Enum.
        /// Llama a TypeScope con la PropertyType de la propiedad.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_propiedad">Propiedad a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsEnumeracion(this PropertyInfo _propiedad)
        {
            try
            {
                if (_propiedad == null)
                {
                    throw new ArgumentNullException("_propiedad", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.EsEnumeracion(_propiedad.PropertyType);
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            } 
        }

        /// <summary>
        /// Comprueba si una propiedad es de tipo <see cref="System.Collections.IDictionary"/>.
        /// Llama a TypeScope con la PropertyType de la propiedad.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_propiedad">Propiedad a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsDiccionario(this PropertyInfo _propiedad)
        {
            try
            {
                if (_propiedad == null)
                {
                    throw new ArgumentNullException("_propiedad", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.EsDiccionario(_propiedad.PropertyType);
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si una propiedad es de tipo colección.
        /// Llama a TypeScope con la PropertyType de la propiedad.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_propiedad">Propiedad a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsColeccion(this PropertyInfo _propiedad)
        {
            try
            {
                if (_propiedad == null)
                {
                    throw new ArgumentNullException("_propiedad", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.EsColeccion(_propiedad.PropertyType);
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si una propiedad es de tipo string. Opcionalmente ofrece que interprete un char como string o no.
        /// Por defecto no se toma un char como string.
        /// Llama a TypeScope con la PropertyType de la propiedad.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_propiedad">Propiedad a comprobar.</param>
        /// <param name="_incluirChar">Indica si se debe tratar a un char como un string. [Opcional]</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsString(this PropertyInfo _propiedad, bool _incluirChar = false)
        {
            try
            {
                if (_propiedad == null)
                {
                    throw new ArgumentNullException("_propiedad", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.EsString(_propiedad.PropertyType, _incluirChar);
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si una propiedad es de tipo decimal.
        /// Llama a TypeScope con la PropertyType de la propiedad.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_propiedad">Propiedad a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsDecimal(this PropertyInfo _propiedad)
        {
            try
            {
                if (_propiedad == null)
                {
                    throw new ArgumentNullException("_propiedad", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.EsDecimal(_propiedad.PropertyType);
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si una propiedad es de tipo bool.
        /// Llama a TypeScope con la PropertyType de la propiedad.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_propiedad">Propiedad a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsBooleano(this PropertyInfo _propiedad)
        {
            try
            {
                if (_propiedad == null)
                {
                    throw new ArgumentNullException("_propiedad", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.EsBooleano(_propiedad.PropertyType);
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si una propiedad es de tipo numérico.
        /// Llama a TypeScope con la PropertyType de la propiedad.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_propiedad">Propiedad a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsNumero(this PropertyInfo _propiedad)
        {
            try
            {
                if (_propiedad == null)
                {
                    throw new ArgumentNullException("_propiedad", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.EsNumero(_propiedad.PropertyType);
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Obtiene el tipo (AssemblyQualifiedName) en singular de una colección.
        /// Llama a TypeScope con la PropertyType de la propiedad.
        /// <example>
        ///     string tS = TipoSingular(IList of UsuarioTO);
        ///         - ts es entonces UsuarioTO.
        /// </example>
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <exception cref="UtilException">Es lanzado al ocurrir una excepción en tiempo de ejecución de cualquier tipo.</exception>
        /// <param name="_propiedad">Propiedad a comprobar.</param>
        /// <returns>AssemblyQualifiedName del tipo en singular.</returns>
        public static string ObtenerTipoSingular(this PropertyInfo _propiedad)
        {
            try
            {
                if (_propiedad == null)
                {
                    throw new ArgumentNullException("_propiedad", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.ObtenerTipoSingular(_propiedad.PropertyType);
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Obtiene la propiedad de un objeto mediante reflexión. Además es válido enviar la propiedad de una propiedad
        /// del modo "Direccion.NumeroCasa". 
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <param name="_objeto">Objeto.</param>
        /// <param name="_propiedad">Nombre de la propiedad.</param>
        /// <returns></returns>
        public static PropertyInfo GetPropiedad(this object _objeto, string _propiedad)
        {
            try
            {
                if (_objeto == null)
                {
                    throw new ArgumentNullException("_objeto", ArgumentoInvalido.NULO.Descripcion);
                }

                if (_propiedad == null)
                {
                    throw new ArgumentNullException("_propiedad", ArgumentoInvalido.NULO.Descripcion);
                }

                string[] propiedades = _propiedad.Split('.');
                PropertyInfo retorno = null;

                object obj = _objeto;

                foreach (string prop in propiedades)
                {
                    retorno = obj.GetType().GetProperty(prop);
                    obj = retorno.GetValue(obj, null);
                }

                return retorno;
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Obtiene el valor de la propiedad de un objeto, especificado, mediante reflexión. Además es válido enviar la propiedad de una propiedad
        /// del modo "Direccion.NumeroCasa". 
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <param name="_objeto">Objeto.</param>
        /// <param name="_propiedad">Nombre de la propiedad.</param>
        /// <returns></returns>
        public static object GetValorPropiedad(this object _objeto, string _propiedad)
        {
            try
            {
                if (_objeto == null)
                {
                    throw new ArgumentNullException("_objeto", ArgumentoInvalido.NULO.Descripcion);
                }

                if (_propiedad == null)
                {
                    throw new ArgumentNullException("_propiedad", ArgumentoInvalido.NULO.Descripcion);
                }
                return GetPropiedad(_objeto, _propiedad).GetValue(_objeto, null);
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Cambia el valor de la propiedad de un objeto, especificado, mediante reflexión.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <param name="_objeto">Objeto.</param>
        /// <param name="_propiedad">Nombre de la propiedad.</param>
        /// <param name="_valor">Valor de la propiead.</param>
        /// <returns></returns>
        public static void SetValorPropiedad(this object _objeto, PropertyInfo _propiedad, object _valor)
        {
            try
            {
                if (_objeto == null)
                {
                    throw new ArgumentNullException("_objeto", ArgumentoInvalido.NULO.Descripcion);
                }

                if (_propiedad == null)
                {
                    throw new ArgumentNullException("_propiedad", ArgumentoInvalido.NULO.Descripcion);
                }

                _propiedad.SetValue(_objeto, _valor, null);
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Obtiene el valor de la propiedad de un objeto, especificado, mediante reflexión.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <param name="_objeto">Objeto.</param>
        /// <param name="_propiedad">Nombre de la propiedad.</param>
        /// <returns></returns>
        public static object GetValorPropiedad(this object _objeto, PropertyInfo _propiedad)
        {
            try
            {
                if (_objeto == null)
                {
                    throw new ArgumentNullException("_objeto", ArgumentoInvalido.NULO.Descripcion);
                }

                if (_propiedad == null)
                {
                    throw new ArgumentNullException("_propiedad", ArgumentoInvalido.NULO.Descripcion);
                }

                return _propiedad.GetValue(_objeto, null);
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }
    }
}
