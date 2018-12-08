using System.IO;
using Tmpps.Infrastructure.Common.IO.Interfaces;

namespace Tmpps.Infrastructure.Common.IO
{
    /// <summary>
    /// パスを解決するためのオブジェクト
    /// </summary>
    public class PathResolver : IPathResolver
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public PathResolver(string rootPath = null)
        {
            this.RootPath = rootPath;
        }
        /// <summary>
        /// RootPath
        /// </summary>
        public string RootPath { get; private set; }
        /// <inheritdoc />
        public string ResolveFilePath(string path)
        {
            if (File.Exists(path))
            {
                return path;
            }
            path = Path.GetFullPath(Path.Combine(this.RootPath, path));
            if (File.Exists(path))
            {
                return path;
            }
            return null;
        }
        /// <inheritdoc />
        public string ResolveDirectoryPath(string path)
        {
            if (Directory.Exists(path))
            {
                return path;
            }
            path = Path.GetFullPath(Path.Combine(this.RootPath, path));
            if (Directory.Exists(path))
            {
                return path;
            }
            return null;
        }
    }
}