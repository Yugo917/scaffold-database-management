CREATE TABLE book (
    id              UUID                            NOT NULL        PRIMARY KEY,
    name            VARCHAR(50)                     NOT NULL,
	creation_date   TIMESTAMP WITHOUT TIME ZONE     NOT NULL
);
