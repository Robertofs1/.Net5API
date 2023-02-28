using RestWithASPNETUdemy.Hypermedia;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.HyperMedia.Abstract
{
    public interface ISuportHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
