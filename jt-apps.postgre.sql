CREATE TABLE newsletters
(
    news_id serial NOT NULL,
    news_title character varying(128) NOT NULL,
    news_description text,
    news_link character varying(256) NOT NULL,
    PRIMARY KEY (news_id)
);