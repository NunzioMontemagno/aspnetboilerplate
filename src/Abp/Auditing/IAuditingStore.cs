﻿namespace Abp.Auditing
{
    /// <summary>
    /// This interface should be implemented by vendors to
    /// make auditing working.
    /// Default implementation is <see cref="SimpleLogAuditingStore"/>.
    /// </summary>
    public interface IAuditingStore
    {
        /// <summary>
        /// Should save audits to a persistent store.
        /// </summary>
        /// <param name="auditInfo">Audit informations</param>
        void Save(AuditInfo auditInfo);
    }

    //TODO: Working on that
    public interface IAuditInfoPopulator
    {
        void Populate(AuditInfo auditInfo);
    }
}