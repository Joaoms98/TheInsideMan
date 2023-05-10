
namespace TheInsideManConsoleApp.Entities.Cards;

public class Deck
{
    #region RegisterCards
    public Card Back { get; set; } = new Card("Back",0,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "."},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, "."},{ 104, "|"},
        { 197, "|"},{ 198, ":"},{ 199, ":"},{ 200, ":"}, { 201, ":"},{ 202, ":"},{ 203, ":"},{ 204, "|"},
        { 297, "|"},{ 298, ":"},{ 299, ":"},{ 300, ":"}, { 301, ":"},{ 302, ":"},{ 303, ":"},{ 304, "|"},
        { 397, "|"},{ 398, "."},{ 399, "."},{ 400, "_"}, { 401, "_"},{ 402, "."},{ 403, "."},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        });

    public List<Card> Cards {get; set;} = new List<Card>(){
        new Card("Paus4",4,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "4"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♣"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♣"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "4"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }), 
        new Card("Ouro4",1,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "4"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "◘"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "◘"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "4"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Espadas4",2,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "4"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♠"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♠"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "4"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Copas4",3,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "4"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♥"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♥"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "4"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Paus5",8,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "5"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♣"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♣"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "5"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Ouro5",5,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "5"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "◘"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "◘"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "5"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Espadas5",6,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "5"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♠"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♠"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "5"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Copas5",7,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "5"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♥"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♥"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "5"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Paus6",12,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "6"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♣"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♣"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "6"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Ouro6",9,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "6"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "◘"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "◘"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "6"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Espadas6",10,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "6"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♠"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♠"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "6"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Copas6",11,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "6"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♥"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♥"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "6"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Paus7",16,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "7"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♣"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♣"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "7"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Ouro7",13,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "7"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "◘"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "◘"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "7"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Espadas7",14,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "7"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♠"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♠"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "7"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Copas7",15,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "7"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♥"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♥"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "7"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("PausQ",20,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "Q"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♣"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♣"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "Q"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("OuroQ",17,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "Q"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "◘"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "◘"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "Q"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("EspadasQ",18,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "Q"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♠"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♠"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "Q"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("CopasQ",19,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "Q"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♥"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♥"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "Q"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("PausJ",24,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "J"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♣"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♣"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "J"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("OuroJ",21,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "J"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "◘"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "◘"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "J"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("EspadasJ",22,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "J"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♠"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♠"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "J"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("CopasJ",23,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "J"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♥"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♥"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "J"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("PausK",28,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "K"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♣"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♣"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "K"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("OuroK",25,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "K"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "◘"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "◘"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "K"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("EspadasK",26,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "K"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♠"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♠"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "K"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("CopasK",27,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "K"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♥"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♥"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "K"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("PausA",32,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "A"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♣"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♣"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "A"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("OuroA",29,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "A"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "◘"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "◘"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "A"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("EspadasA",30,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "A"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♠"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♠"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "A"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("CopasA",31,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "A"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♥"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♥"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "A"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Paus2",36,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "2"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♣"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♣"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "2"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Ouro2",33,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "2"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "◘"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "◘"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "2"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Espadas2",34,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "2"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♠"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♠"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "2"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Copas2",35,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "2"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♥"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♥"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "2"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Paus3",40,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "3"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♣"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♣"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "3"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Ouro3",37,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "3"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "◘"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "◘"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "3"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Espadas3",38,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "3"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♠"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♠"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "3"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
        new Card("Copas3",39,new Dictionary<int, string> {
        { -3, "."},{ -2, "-"},{ -1, "-"},{ 0, "-"},{ 1,"-"},{ 2, "-"},{ 3, "-"},{ 4, "."},
        { 97, "|"},{ 98, "3"},{ 99, "."},{ 100, "-"}, { 101, "-"},{ 102, "."},{ 103, " "},{ 104, "|"},
        { 197, "|"},{ 198, " "},{ 199, ":"},{ 200, " "}, { 201, "♥"},{ 202, ":"},{ 203, " "},{ 204, "|"},
        { 297, "|"},{ 298, " "},{ 299, ":"},{ 300, "♥"}, { 301, " "},{ 302, ":"},{ 303, " "},{ 304, "|"},
        { 397, "|"},{ 398, " "},{ 399, "'"},{ 400, "-"}, { 401, "-"},{ 402, "'"},{ 403, "3"},{ 404, "|"},
        { 497, "`"},{ 498, "-"},{ 499, "-"},{ 500, "-"}, { 501, "-"},{ 502, "-"},{ 503, "-"},{ 504, "'"},
        }),
    };
    #endregion
}