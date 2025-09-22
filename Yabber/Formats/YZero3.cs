using SoulsFormats.AC4;
using System.IO;

namespace Yabber
{
    static class YZero3
    {
        public static void Unpack(this Zero3 z3, string targetDir)
        {
            foreach (Zero3.File file in z3.Files)
            {
                string normalizedName = file.Name.Replace('\\', '/');
                string outPath = Path.Combine(targetDir, normalizedName);
                string outDir = Path.GetDirectoryName(outPath);
                if (!string.IsNullOrWhiteSpace(outDir))
                    Directory.CreateDirectory(outDir);
                File.WriteAllBytes(outPath, file.Bytes);
            }
        }
    }
}
