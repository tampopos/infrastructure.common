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
                return Path.GetFullPath(path);
            }
            var combinePath = Path.Combine(this.RootPath, path);
            if (File.Exists(combinePath))
            {
                return Path.GetFullPath(combinePath);
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
            var combinePath = Path.Combine(this.RootPath, path);
            if (Directory.Exists(combinePath))
            {
                return Path.GetFullPath(combinePath);
            }
            return null;
        }
    }
}