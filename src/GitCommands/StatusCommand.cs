using LibGit2Sharp;

namespace GitCommands
{
    public class StatusCommand
    {
        public bool Execute(string path)
        {
            using (var repo = new Repository(path))
            {
                var status = repo.RetrieveStatus(new StatusOptions
                {
                    IncludeIgnored = false,
                    IncludeUnaltered = false,
                    DetectRenamesInWorkDir = true,
                    Show = StatusShowOption.WorkDirOnly
                });
                return status.IsDirty;
            }
        }
    }
}
