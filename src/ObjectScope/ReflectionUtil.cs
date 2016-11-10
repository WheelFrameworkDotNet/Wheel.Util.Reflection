using System;
using System.Collections;
using System.Reflection;
using Wheel.Core.Exceptions;
using Wheel.Util.Core.Exceptions;

namespace Wheel.Util.Reflection.ObjectScope
{
    /// <summary>
    /// Utilitario de reflexión con alcance de Object.
    /// </summary>
    /// <remarks>
    ///     Registro de versiones:
    ///     
    ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
    /// </remarks>
    public static class ReflectionUtil
    {
        /// <summary>
        /// Comprueba si un objeto es de tipo creado por el usuario (no primitivo) o de C#(primitivo).
        /// Llama a TypeScope con GetType() del objeto.
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
        /// <param name="_objeto">Objeto a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsPrimitivo(this object _objeto)
        {
            try
            {
                if (_objeto == null)
                {
                    throw new ArgumentNullException("_objeto", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.EsPrimitivo(_objeto.GetType());
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un objeto es de tipo colección.
        /// Llama a TypeScope con GetType() del objeto.
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
        /// <param name="_objeto">Objeto a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsColeccion(this object _objeto)
        {
            try
            {
                if (_objeto == null)
                {
                    throw new ArgumentNullException("_objeto", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.EsColeccion(_objeto.GetType());
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un objeto es de tipo Enum.
        /// Llama a TypeScope con GetType() del objeto.
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
        /// <param name="_objeto">Objeto a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsEnumeracion(this object _objeto)
        {
            try
            {
                if (_objeto == null)
                {
                    throw new ArgumentNullException("_objeto", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.EsEnumeracion(_objeto.GetType());
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un objeto es de tipo decimal.
        /// Llama a TypeScope con GetType() del objeto.
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
        /// <param name="_objeto">Objeto a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsDecimal(this object _objeto)
        {
            try
            {
                if (_objeto == null)
                {
                    throw new ArgumentNullException("_objeto", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.EsDecimal(_objeto.GetType());
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un objeto es de tipo numérico.
        /// Llama a TypeScope con GetType() del objeto.
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
        /// <param name="_objeto">Objeto a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsNumero(this object _objeto)
        {
            try
            {
                if (_objeto == null)
                {
                    throw new ArgumentNullException("_objeto", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.EsNumero(_objeto.GetType());
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un objeto es de tipo bool.
        /// Llama a TypeScope con GetType() del objeto.
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
        /// <param name="_objeto">Objeto a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsBooleano(this object _objeto)
        {
            try
            {
                if (_objeto == null)
                {
                    throw new ArgumentNullException("_objeto", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.EsBooleano(_objeto.GetType());
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un objeto es de tipo string. Opcionalmente ofrece que interprete un char como string o no.
        /// Por defecto no se toma un char como string.
        /// Llama a TypeScope con GetType() del objeto.
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
        /// <param name="_objeto">Objeto a comprobar.</param>
        /// <param name="_incluirChar">Indica si se debe tratar a un char como un string. [Opcional]</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsString(this object _objeto, bool _incluirChar = false)
        {
            try
            {
                if (_objeto == null)
                {
                    throw new ArgumentNullException("_objeto", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.EsString(_objeto.GetType(), _incluirChar);
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Comprueba si un objeto es de tipo <see cref="IDictionary"/>.
        /// Llama a TypeScope con GetType() del objeto.
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
        /// <param name="_objeto">Objeto a comprobar.</param>
        /// <returns><value>true</value> en caso de serlo, o <value>false</value> de lo contrario.</returns>
        public static bool EsDiccionario(this object _objeto)
        {
            try
            {
                if (_objeto == null)
                {
                    throw new ArgumentNullException("_objeto", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.EsDiccionario(_objeto.GetType());
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Obtiene el tipo (AssemblyQualifiedName) en singular de una colección.
        /// Llama a TypeScope con GetType() del objeto.
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
        /// <param name="_objeto">Objeto a comprobar.</param>
        /// <returns>AssemblyQualifiedName del tipo en singular.</returns>
        public static string ObtenerTipoSingular(this object _objeto)
        {
            try
            {
                if (_objeto == null)
                {
                    throw new ArgumentNullException("_objeto", ArgumentoInvalido.NULO.Descripcion);
                }

                return TypeScope.ReflectionUtil.ObtenerTipoSingular(_objeto.GetType());
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }

        /// <summary>
        /// Cambia el valor de la propiedad de un objeto, mediante reflexión.Además es válido enviar la propiedad de una propiedad
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
        /// <param name="_valor">Valor de la propiedad.</param>
        public static void SetValorPropiedad(this object _objeto, string _propiedad, object _valor)
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
                foreach (string prop in propiedades)
                {
                    PropertyInfo xprop = InfoScope.ReflectionUtil.GetPropiedad(_objeto, prop);

                    if (InfoScope.ReflectionUtil.GetValorPropiedad(_objeto, xprop) == null)
                    {
                        if (xprop.EsPrimitivo())
                        {
                            InfoScope.ReflectionUtil.SetValorPropiedad(_objeto, xprop, _valor);
                        }
                        else
                        {
                            InfoScope.ReflectionUtil.SetValorPropiedad(_objeto, xprop, CrearInstancia(xprop.PropertyType.Name));
                        }
                    }
                }
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
            return InfoScope.ReflectionUtil.GetPropiedad(_objeto, _propiedad);
        }

        /// <summary>
        /// Obtiene una nueva instancia del tipo especificado.
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
        /// <param name="tipo">Tipo de la instancia.</param>
        /// <param name="parametros">Array de parametros del contructor de ese tipo.</param>
        /// <returns></returns>
        public static object CrearInstancia(string tipo, object[] parametros = null)
        {
            return TypeScope.ReflectionUtil.CrearInstancia(Type.GetType(tipo), parametros);
        }
    }
}
