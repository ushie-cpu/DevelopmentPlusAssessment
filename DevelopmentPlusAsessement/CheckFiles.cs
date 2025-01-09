namespace DevelopmentPlusAsessement
{
    public static class CheckFiles
    {
        public static string FindText(string folder, string text)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var fullPath = Path.Combine(currentDirectory, Path.Combine("wwwroot", folder));

            var result = string.Empty;
            if (Path.Exists(fullPath))
            {
                text = text.ToLower();
                var files = Directory.GetFiles(fullPath);

                foreach (var file in files)
                {
                    var content = File.ReadAllText(file).ToLower();

                    if (content.Contains(text))
                    {
                        result += $"Present: {Path.GetFileName(file)}\n";
                    }
                    else
                    {
                        result += $"Absent: {Path.GetFileName(file)}\n";
                    }
                }
            }
            else
            {
                return $"Folder {folder} not found";
            }
            return result;
        }
    }
}
