#load nuget:https://pkgs.dev.azure.com/cake-contrib/Home/_packaging/addins/nuget/v3/index.json?package=Cake.Wyam.Recipe&prerelease
//#load nuget:?package=Cake.Wyam.Recipe


Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                            buildSystem: BuildSystem,
                            title: "docs",
                            repositoryOwner: "gep13",
                            repositoryName: "wyam-test",
                            appVeyorAccountName: "gep13",
                            webHost: "gep13.co.uk",
                            shouldPurgeCloudflareCache: true,
                            wyamRecipe: "Docs",
                            wyamTheme: "Samson");

BuildParameters.PrintParameters(Context);

Build.Run();