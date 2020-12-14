using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_boats {
    public enum BoardType { Opponent, Personal };
    public enum GameType { Computer, Local};
    class Player {
        public Player(List<GameLogic.Boat> PlacedBoats, GameType GameMode) {
            placedBoats = PlacedBoats;
            gameMode = GameMode;
            opponentBoard = new Board(BoardType.Opponent);
            personalBoard = new Board(BoardType.Personal);
        }

        // Board class to manage the different layers
        public class Board {
            /* On a board where you hit: 
                                            -1 = nothing
                                             0 = not hit / water
                                             1 = hit

              On your board:
                                            -1 = water
                                             n = boat index
              */

            public Board(BoardType Type) {
                type = Type;
                board = new int[10, 10];
                for (int col = 0; col < 10; col++) {
                    for (int row = 0; row < 10; row++) {
                        board[col, row] = 0;
                    }
                }
            }
            public int[,] board { get; set; }
            public BoardType type { get; set; }
        }

        private List<GameLogic.Boat> placedBoats { get; set; }
        private Board opponentBoard { get; set; }
        private Board personalBoard { get; set; }
        private GameType gameMode { get; set; }
    }
}
