using System;
using Wheel.Core.Exceptions;
using Wheel.Util.Core.Exceptions;

namespace Wheel.Util.Reflection.OtherScope
{
    /// <summary>
    /// Utilitario de reflexión con alcance de Other.
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
        /// Obtiene el tipo (AssemblyQualifiedName) en singular del nombre completo del ensamblado de un tipo(AssemblyQualifiedName). 
        /// <example>
        ///     string tS = TipoSingular("IList<UsuarioTO/>;v1.0;publicKeyToken=065djhkg645;a.dll");
        ///         - ts es entonces "UsuarioTO;v1.0;publicKeyToken=065djhkg645;a.dll".
        ///     NOTA: El AssemblyQualifiedName de ejemplo, no es fielmente correcto. Sólo es para hacerse una idea.
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
        /// <param name="_assemblyQualifiedName">AssemblyQualifiedName de la colección.</param>
        /// <returns>AssemblyQualifiedName del tipo en singular.</returns>
        public static string ObtenerTipoSingular(this string _assemblyQualifiedName)
        {
            try
            {
                if (_assemblyQualifiedName == null)
                {
                    throw new ArgumentNullException("_assemblyQualifiedName", ArgumentoInvalido.NULO.Descripcion);
                }

                string retorno = _assemblyQualifiedName;
                string assemblyName = _assemblyQualifiedName.Replace("[", "").Replace("]", "");
                if (assemblyName.Contains("List"))
                {
                    assemblyName = assemblyName.Substring(assemblyName.IndexOf("List") + 6);
                    assemblyName = assemblyName.Replace(_assemblyQualifiedName, "");
                    _assemblyQualifiedName = _assemblyQualifiedName.Substring(0, _assemblyQualifiedName.IndexOf("]"));
                }

                int largo = assemblyName.IndexOf(",");

                if (largo != -1)
                {
                    assemblyName = assemblyName.Substring(0, largo);
                }

                string typeName = assemblyName.Substring(assemblyName.IndexOf(".") + 1);
                assemblyName = assemblyName.Substring(0, assemblyName.IndexOf("."));

                retorno = assemblyName + "." + typeName + _assemblyQualifiedName.Substring(_assemblyQualifiedName.IndexOf(","));
                return retorno;
            }
            catch (Exception e)
            {
                throw new UtilException(e.Message, e);
            }
        }
    }
}
