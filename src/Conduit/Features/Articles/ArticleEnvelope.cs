using Conduit.Domain;

namespace Conduit.Features.Articles
{
	//this is a comment
    public class ArticleEnvelope
    {
        public ArticleEnvelope(Article article)
        {
            Article = article;
        }

        public Article Article { get; }
    }
}