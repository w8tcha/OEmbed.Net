﻿namespace OEmbedSharp.Providers;

public record VimeoProvider : Provider
{
    public VimeoProvider()
    {
        this.Name = "Vimeo";
        this.Hosts = new List<string>
                         {
                             "vimeo.com",
                             "www.vimeo.com",
                             "player.vimeo.com"
                         };

        this.AddMatches(
            @"/(?:channels\/(?:\w+\/)|groups\/(?:[^\/]*\/videos)\/|ondemand(.+)|)(\d+)?(?:|\/\?)(?:\?\S+)?",
            @"/(?!ondemand)\w+\/(\w+)(?:(?:\?|\#)\S+)?");

        this.Endpoint = "https://vimeo.com/api/oembed.json";
    }
}