﻿namespace OEmbedSharp.Providers;

public record DeviantArtProvider : Provider
{
    public DeviantArtProvider()
    {
        this.Name = "DeviantArt";
        this.Hosts = new List<string> { "www.deviantart.com", "deviantart.com", "fav.me", "sta.sh" };
        
        this.AddMatches(
            /*
             * https://www.deviantart.com/{author_name}/art/{id}
             * https://www.deviantart.com/art/{id}
             */
            @"/(?:[a-z0-9-_]+/)?art/([\S]+)/?",
            /*
             * https://fav.me/{id}
             * https://sta.sh/{id}
             */
            "/([a-zA-Z0-9]+)/?");

        this.Endpoint = "https://backend.deviantart.com/oembed";
    }
}