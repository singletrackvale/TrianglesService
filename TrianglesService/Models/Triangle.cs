using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrianglesService.Models
{
    /// <summary>
    /// Represents a Triangle with 3 vertices, and a row and column,
    /// indicating placement on a grid.
    /// </summary>
    public class Triangle
    {

        public int V1x { get; set; }
        public int V1y { get; set; }
        public int V2x { get; set; }
        public int V2y { get; set; }
        public int V3x { get; set; }
        public int V3y { get; set; }
        public int Column { get; set; }
        public string Row { get; set; }

        public Triangle()
        { }

        /// <summary>
        /// calculates the vertices for the Triangle
        /// </summary>
        /// <returns>true if calc was success</returns>
        public bool GetVertices(string row, int col)
        {
            try
            {
                int irow = char.ToUpper(row[0]);
                // 1st validate params
                if ((irow >= 65 && irow <= 70) && (col >= 1 && col <= 12))
                {
                    int chgX, chgY;

                    // offset for base 0 and char value
                    int nrow = irow - 65;
                    int ncol = col - 1;

                    this.Column = col;
                    this.Row = row;

                    // set values based on odd or even column
                    if (ncol % 2 == 1) // odd
                    {
                        chgX = -10;
                        chgY = 10;
                        this.V1x = (((ncol) / 2) * 10) + 10;
                        this.V1y = nrow * 10;
                    }
                    else // even
                    {
                        chgX = 10;
                        chgY = -10;
                        this.V1x = (ncol / 2) * 10;
                        this.V1y = (nrow * 10) + 10;
                    }

                    this.V2x = this.V1x;
                    this.V2y = this.V1y + chgY;
                    this.V3x = this.V1x + chgX;
                    this.V3y = this.V1y;
                    this.Column = col;
                    this.Row = row;

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// calculates row/column for a Triangle
        /// </summary>
        /// <returns>true if calc was success</returns>
        public bool GetRowColumn(int v1x, int v1y, int v2x, int v2y, int v3x, int v3y)
        {
            try
            {
                // validate coordinates
                if (ValidateVertices(v1x, v1y, v2x, v2y, v3x, v3y))
                {

                    int row, col;

                    if (v1x > v3x) // odd
                    {
                        col = ((2 * (v1x - 10)) / 10) + 1;
                        row = v1y / 10;
                    }
                    else // even
                    {
                        col = 2 * (v1x / 10);
                        row = (v1y - 10) / 10;
                    }

                    // convert to actual row/col values
                    this.Row = Convert.ToChar(row + 65).ToString();
                    this.Column = col + 1;
                    this.V1x = v1x;
                    this.V1y = v1y;
                    this.V2x = v2x;
                    this.V2y = v2y;
                    this.V3x = v3x;
                    this.V3y = v3y;

                    return true;
                }
                else
                    return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Verifies that vertices are valid grid coordinates.
        /// </summary>
        /// <returns>true if verts are valid.</returns>
        private bool ValidateVertices(int v1x, int v1y, int v2x, int v2y, int v3x, int v3y)
        {
            bool rtn = false;

            // based on v1 values
            if ((v1x >= 0 && v1x <= 60) && (v1y >= 0 && v1y <= 60))
            {
                if( (v2x == v1x) && (v2y == (v1y + 10)) ) // odd
                {
                    if( (v3x == (v1x - 10)) && v3y == v1y )
                    {
                        rtn = true;
                    }
                }
                else if ( (v2x == v1x) && (v2y == (v1y - 10)) ) // even
                {
                    if( (v3x == (v1x + 10)) && v3y == v1y )
                    {
                        rtn = true;
                    }
                }
            }

            return rtn;
        }

    }    

}