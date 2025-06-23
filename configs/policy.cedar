permit(
    principal == User::"alice",
    action == Action::"read",
    resource == Resource::"config-tenant"
);

permit(
  principal in Group::"global-admin",
  action == Action::"create",
  resource == Resource::"app"
);

permit(
  principal in Group::"tenant-admin",
  action == Action::"execute",
  resource == Resource::"run"
);
