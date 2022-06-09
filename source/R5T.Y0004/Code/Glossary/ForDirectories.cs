using System;


namespace R5T.Y0004
{
    public static partial class Glossary
    {
        public static class ForDirectories
        {
            /// <summary>
            /// <inheritdoc cref="RepositoryDirectory" path="/definition"/>
            /// </summary>
            /// <definition>A repository directory contains the <inheritdoc cref="RepositoryGitDirectory" path="/name"/> directory, as well as all the files in the repository.</definition>
            /// <name><i>repository directory</i></name>
            public static readonly object RepositoryDirectory;

            /// <summary>
            /// <inheritdoc cref="RepositoryGitDirectory" path="/definition"/>
            /// </summary>
            /// <definition>Every git repository has a ".git" directory containing all git-related files.</definition>
            /// <name><i>git directory</i></name>
            public static readonly object RepositoryGitDirectory;
        }
    }
}
