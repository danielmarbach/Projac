﻿using System.Collections.Generic;

namespace Paramol
{
    /// <summary>
    /// Represents the synchronous execution of a set of <see cref="SqlNonQueryStatement">statements</see> against a data source.
    /// </summary>
    public interface ISqlNonQueryStatementExecutor
    {
        /// <summary>
        /// Executes the specified statements.
        /// </summary>
        /// <param name="statements">The statements.</param>
        /// <exception cref="System.ArgumentNullException">Throws when <paramref name="statements"/> are <c>null</c>.</exception>
        void Execute(IEnumerable<SqlNonQueryStatement> statements);
    }
}